using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models.HEPMA;

namespace WebApplication1.Controllers
{
    public class NotesFieldLocationOfInterestController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: NotesFieldLocationOfInterest
        public ActionResult Index()
        {
            var notesFieldLocationOfInterests = db.NotesFieldLocationOfInterests.Include(n => n.locationOf);
            return View(notesFieldLocationOfInterests.ToList());
        }

        // GET: NotesFieldLocationOfInterest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterests.Find(id);
            if (notesFieldLocationOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldLocationOfInterest);
        }

        // GET: NotesFieldLocationOfInterest/Create
        public ActionResult Create()
        {
            ViewBag.LoIId = new SelectList(db.LocationOfInterests, "LoIId", "LoIName");
            return View();
        }

        // POST: NotesFieldLocationOfInterest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,LoIId,Note")] NotesFieldLocationOfInterest notesFieldLocationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.NotesFieldLocationOfInterests.Add(notesFieldLocationOfInterest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoIId = new SelectList(db.LocationOfInterests, "LoIId", "LoIName", notesFieldLocationOfInterest.LoIId);
            return View(notesFieldLocationOfInterest);
        }

        // GET: NotesFieldLocationOfInterest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterests.Find(id);
            if (notesFieldLocationOfInterest == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoIId = new SelectList(db.LocationOfInterests, "LoIId", "LoIName", notesFieldLocationOfInterest.LoIId);
            return View(notesFieldLocationOfInterest);
        }

        // POST: NotesFieldLocationOfInterest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,LoIId,Note")] NotesFieldLocationOfInterest notesFieldLocationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notesFieldLocationOfInterest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoIId = new SelectList(db.LocationOfInterests, "LoIId", "LoIName", notesFieldLocationOfInterest.LoIId);
            return View(notesFieldLocationOfInterest);
        }

        // GET: NotesFieldLocationOfInterest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterests.Find(id);
            if (notesFieldLocationOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldLocationOfInterest);
        }

        // POST: NotesFieldLocationOfInterest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterests.Find(id);
            db.NotesFieldLocationOfInterests.Remove(notesFieldLocationOfInterest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
