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
    public class NotesFieldsSiteLocationController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: NotesFieldsSiteLocation
        public ActionResult Index()
        {
            var notesFieldSiteLocations = db.LocationNotes.Include(n => n.SiteLocation);
            return View(notesFieldSiteLocations.ToList());
        }

        // GET: NotesFieldsSiteLocation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldSiteLocation notesFieldSiteLocation = db.LocationNotes.Find(id);
            if (notesFieldSiteLocation == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldSiteLocation);
        }

        // GET: NotesFieldsSiteLocation/Create
        public ActionResult Create(int id)
        {
            NotesFieldSiteLocation LocationNotes = new NotesFieldSiteLocation();
            LocationNotes.SiteLocationId = id;
            return View(LocationNotes);
        }

        // POST: NotesFieldsSiteLocation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,SiteLocationId,Note")] NotesFieldSiteLocation notesFieldSiteLocation)
        {
            if (ModelState.IsValid)
            {
                db.LocationNotes.Add(notesFieldSiteLocation);
                db.SaveChanges();
                return RedirectToAction("../SiteLocations/Details/", new { id = notesFieldSiteLocation.SiteLocationId });
            }

            return View(notesFieldSiteLocation);
        }

        // GET: NotesFieldsSiteLocation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldSiteLocation notesFieldSiteLocation = db.LocationNotes.Find(id);
            if (notesFieldSiteLocation == null)
            {
                return HttpNotFound();
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", notesFieldSiteLocation.SiteLocationId);
            return View(notesFieldSiteLocation);
        }

        // POST: NotesFieldsSiteLocation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,SiteLocationId,Note")] NotesFieldSiteLocation notesFieldSiteLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notesFieldSiteLocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", notesFieldSiteLocation.SiteLocationId);
            return View(notesFieldSiteLocation);
        }

        // GET: NotesFieldsSiteLocation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldSiteLocation notesFieldSiteLocation = db.LocationNotes.Find(id);
            if (notesFieldSiteLocation == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldSiteLocation);
        }

        // POST: NotesFieldsSiteLocation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesFieldSiteLocation notesFieldSiteLocation = db.LocationNotes.Find(id);
            db.LocationNotes.Remove(notesFieldSiteLocation);
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
