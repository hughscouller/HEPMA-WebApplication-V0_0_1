using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models.HEPMA;

namespace WebApplication1.Controllers
{
    public class NotesFieldAreaOfCaresController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: NotesFieldAreaOfCares
        public ActionResult Index()
        {
            return View(db.NotesFieldAreaOfCares.ToList());
        }

        // GET: NotesFieldAreaOfCares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldAreaOfCare notesFieldAreaOfCare = db.NotesFieldAreaOfCares.Find(id);
            if (notesFieldAreaOfCare == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldAreaOfCare);
        }

        // GET: NotesFieldAreaOfCares/Create
        public ActionResult Create(int id)
        {
            NotesFieldAreaOfCare notesFieldAreaOfCare = new NotesFieldAreaOfCare();
            notesFieldAreaOfCare.AoCId = id;

            return View(notesFieldAreaOfCare);
        }

        // POST: NotesFieldAreaOfCares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,AoCId,Note")] NotesFieldAreaOfCare notesFieldAreaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.NotesFieldAreaOfCares.Add(notesFieldAreaOfCare);
                db.SaveChanges();
                return RedirectToAction("../AreasOfCare/Details", new { id = notesFieldAreaOfCare.AoCId });
            }

            return View(notesFieldAreaOfCare);
        }

        // GET: NotesFieldAreaOfCares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldAreaOfCare notesFieldAreaOfCare = db.NotesFieldAreaOfCares.Find(id);
            if (notesFieldAreaOfCare == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldAreaOfCare);
        }

        // POST: NotesFieldAreaOfCares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreatedBy,CreatedOn,NoteType,AoCId,Note")] NotesFieldAreaOfCare notesFieldAreaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notesFieldAreaOfCare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notesFieldAreaOfCare);
        }

        // GET: NotesFieldAreaOfCares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFieldAreaOfCare notesFieldAreaOfCare = db.NotesFieldAreaOfCares.Find(id);
            if (notesFieldAreaOfCare == null)
            {
                return HttpNotFound();
            }
            return View(notesFieldAreaOfCare);
        }

        // POST: NotesFieldAreaOfCares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesFieldAreaOfCare notesFieldAreaOfCare = db.NotesFieldAreaOfCares.Find(id);
            db.NotesFieldAreaOfCares.Remove(notesFieldAreaOfCare);
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
