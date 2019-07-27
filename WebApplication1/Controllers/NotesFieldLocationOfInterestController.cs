using System.Data.Entity;
using System.Linq;
using System.Net;
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
            var notesFieldLocationOfInterests = db.NotesFieldLocationOfInterest.Include(n => n.LocationOfInterest);
            return View(notesFieldLocationOfInterests.ToList());
        }

        // GET: NotesFieldLocationOfInterest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterest.Find(id);
            if (notesFieldLocationOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldLocationOfInterest);
        }

        // GET: NotesFieldLocationOfInterest/Create
        public ActionResult Create(int id)
        {
            NotesFieldLocationOfInterest NFLoI = new NotesFieldLocationOfInterest();
            NFLoI.LoIId = id;

            return View(NFLoI);
        }

        // POST: NotesFieldLocationOfInterest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,LoIId,Note")] NotesFieldLocationOfInterest notesFieldLocationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.NotesFieldLocationOfInterest.Add(notesFieldLocationOfInterest);
                db.SaveChanges();
                return RedirectToAction("../LocationsOfInterest/Details/", new { id = notesFieldLocationOfInterest.LoIId });
            }

            ViewBag.LoIId = new SelectList(db.LocationOfInterest, "LoIId", "LoIName", notesFieldLocationOfInterest.LoIId);
            return View(notesFieldLocationOfInterest);
        }

        // GET: NotesFieldLocationOfInterest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterest.Find(id);
            if (notesFieldLocationOfInterest == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoIId = new SelectList(db.LocationOfInterest, "LoIId", "LoIName", notesFieldLocationOfInterest.LoIId);
            return View(notesFieldLocationOfInterest);
        }

        // POST: NotesFieldLocationOfInterest/Edit/5
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
            ViewBag.LoIId = new SelectList(db.LocationOfInterest, "LoIId", "LoIName", notesFieldLocationOfInterest.LoIId);
            return View(notesFieldLocationOfInterest);
        }

        // GET: NotesFieldLocationOfInterest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterest.Find(id);
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
            NotesFieldLocationOfInterest notesFieldLocationOfInterest = db.NotesFieldLocationOfInterest.Find(id);
            db.NotesFieldLocationOfInterest.Remove(notesFieldLocationOfInterest);
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
