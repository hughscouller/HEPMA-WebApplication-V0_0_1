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
    public class NotesFieldsHospitalSiteController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: NotesFieldsHospitalSite
        public ActionResult Index()
        {
            return View(db.HospitalNotes.ToList());
        }

        // GET: NotesFieldsHospitalSite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldHospitalSite notesFieldHospitalSite = db.HospitalNotes.Find(id);
            if (notesFieldHospitalSite == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldHospitalSite);
        }

        // GET: NotesFieldsHospitalSite/Create
        public ActionResult Create(int id)
        {
            NotesFieldHospitalSite HospitalNotes = new NotesFieldHospitalSite();
            HospitalNotes.HospitalId = id;
            return View(HospitalNotes);
        }

        // POST: NotesFieldsHospitalSite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,HospitalId,Note")] NotesFieldHospitalSite notesFieldHospitalSite)
        {
            if (ModelState.IsValid)
            {
                db.HospitalNotes.Add(notesFieldHospitalSite);
                db.SaveChanges();
                return RedirectToAction("../HospitalSites/Details/", new { id = notesFieldHospitalSite.HospitalId });
            }

            return View(notesFieldHospitalSite);
        }

        // GET: NotesFieldsHospitalSite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldHospitalSite notesFieldHospitalSite = db.HospitalNotes.Find(id);
            if (notesFieldHospitalSite == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldHospitalSite);
        }

        // POST: NotesFieldsHospitalSite/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,HospitalId,Note")] NotesFieldHospitalSite notesFieldHospitalSite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notesFieldHospitalSite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notesFieldHospitalSite);
        }

        // GET: NotesFieldsHospitalSite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldHospitalSite notesFieldHospitalSite = db.HospitalNotes.Find(id);
            if (notesFieldHospitalSite == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldHospitalSite);
        }

        // POST: NotesFieldsHospitalSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesFieldHospitalSite notesFieldHospitalSite = db.HospitalNotes.Find(id);
            db.HospitalNotes.Remove(notesFieldHospitalSite);
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
