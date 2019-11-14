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
    public class NotesFieldsController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: NotesFields
        public ActionResult Index()
        {
            return View(db.NotesFields.ToList());
        }

        // GET: NotesFields/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesField notesField = db.NotesFields.Find(id);
            if (notesField == null)
            {
                return HttpNotFound();
            }
            return View(notesField);
        }

        // GET: NotesFields/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotesFields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Created,CreatedBy,NoteType,Note,NoteContext,NoteContextIdId")] NotesField notesField)
        {
            if (ModelState.IsValid)
            {
                db.NotesFields.Add(notesField);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notesField);
        }

        // GET: NotesFields/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesField notesField = db.NotesFields.Find(id);
            if (notesField == null)
            {
                return HttpNotFound();
            }
            return View(notesField);
        }

        // POST: NotesFields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Created,CreatedBy,NoteType,Note,NoteContext,NoteContextIdId")] NotesField notesField)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notesField).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notesField);
        }

        // GET: NotesFields/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesField notesField = db.NotesFields.Find(id);
            if (notesField == null)
            {
                return HttpNotFound();
            }
            return View(notesField);
        }

        // POST: NotesFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesField notesField = db.NotesFields.Find(id);
            db.NotesFields.Remove(notesField);
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
