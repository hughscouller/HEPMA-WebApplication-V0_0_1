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
    public class BaUChecklistsController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: BaUChecklists
        public ActionResult Index()
        {
            var baUChecklists = db.BaUChecklists.Include(b => b.SiteLocation);
            return View(baUChecklists.ToList());
        }

        // GET: BaUChecklists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaUChecklist baUChecklist = db.BaUChecklists.Find(id);
            if (baUChecklist == null)
            {
                return HttpNotFound();
            }
            return View(baUChecklist);
        }

        // GET: BaUChecklists/Create
        public ActionResult Create()
        {
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name");
            return View();
        }

        // POST: BaUChecklists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BaUChecklistId,BaUChecklistSuccessfulGoLive,BaUChecklistSuccessfulGoliveNotes,BaUChecklistTrainingComplete,BaUChecklistTrainingCompleteNotes,BaUChecklistUserSetup,BaUChecklisUserSetupNotes,BaUChecklistHardwareSetup,BaUChecklistHardwareSetupNotes,BaUChecklistHardwareUseAgreed,BaUChecklistHardwareUseAgreedNotes,BaUChecklistContingencyAgreed,BaUChecklistContingencyAgreedNotes,SiteLocationId")] BaUChecklist baUChecklist)
        {
            if (ModelState.IsValid)
            {
                db.BaUChecklists.Add(baUChecklist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", baUChecklist.SiteLocationId);
            return View(baUChecklist);
        }

        // GET: BaUChecklists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaUChecklist baUChecklist = db.BaUChecklists.Find(id);
            if (baUChecklist == null)
            {
                return HttpNotFound();
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", baUChecklist.SiteLocationId);
            return View(baUChecklist);
        }

        // POST: BaUChecklists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BaUChecklistId,BaUChecklistSuccessfulGoLive,BaUChecklistSuccessfulGoliveNotes,BaUChecklistTrainingComplete,BaUChecklistTrainingCompleteNotes,BaUChecklistUserSetup,BaUChecklisUserSetupNotes,BaUChecklistHardwareSetup,BaUChecklistHardwareSetupNotes,BaUChecklistHardwareUseAgreed,BaUChecklistHardwareUseAgreedNotes,BaUChecklistContingencyAgreed,BaUChecklistContingencyAgreedNotes,SiteLocationId")] BaUChecklist baUChecklist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baUChecklist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", baUChecklist.SiteLocationId);
            return View(baUChecklist);
        }

        // GET: BaUChecklists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaUChecklist baUChecklist = db.BaUChecklists.Find(id);
            if (baUChecklist == null)
            {
                return HttpNotFound();
            }
            return View(baUChecklist);
        }

        // POST: BaUChecklists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaUChecklist baUChecklist = db.BaUChecklists.Find(id);
            db.BaUChecklists.Remove(baUChecklist);
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
