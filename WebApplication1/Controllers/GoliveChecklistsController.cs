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
    public class GoliveChecklistsController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: GoliveChecklists
        public ActionResult Index()
        {
            var goliveChecklists = db.GoliveChecklists.Include(g => g.SiteLocation);
            return View(goliveChecklists.ToList());
        }

        // GET: GoliveChecklists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoliveChecklist goliveChecklist = db.GoliveChecklists.Find(id);
            if (goliveChecklist == null)
            {
                return HttpNotFound();
            }
            return View(goliveChecklist);
        }

        // GET: GoliveChecklists/Create
        public ActionResult Create()
        {
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name");
            return View();
        }

        // POST: GoliveChecklists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GoliveChecklistId,GoliveChecklistUsersIdentified,GoliveChecklistUsersIdentifiedDate,GoliveChecklistUsersTrained,GoliveChecklistUsersTrainedDate,GoliveChecklistUsersSetup,GoliveChecklistUsersSetupDate,GoliveChecklistIdentified,GoliveChecklistIdentifiedDate,GoliveChecklistAgreedUse,GoliveChecklistAgreedUseDate,GoliveChecklistSetupCurrent,GoliveChecklistSetupCurrentDate,GoliveChecklistSetupNew,GoliveChecklistSetupNewDate,GoliveChecklistPrescribing,GoliveChecklistPrescribingDate,GoliveChecklistMedAdmin,GoliveChecklistMedAdminDate,GoliveChecklistPharmCheck,GoliveChecklistPharmCheckDate,GoliveChecklistContingencyAgreed,GoliveChecklistContingencyAgreedDate,GoliveChecklistGo_Nogo,GoliveChecklistGo_NogoDate,GoliveChecklistGeneralNotes,SiteLocationId")] GoliveChecklist goliveChecklist)
        {
            if (ModelState.IsValid)
            {
                db.GoliveChecklists.Add(goliveChecklist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", goliveChecklist.SiteLocationId);
            return View(goliveChecklist);
        }

        // GET: GoliveChecklists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoliveChecklist goliveChecklist = db.GoliveChecklists.Find(id);
            if (goliveChecklist == null)
            {
                return HttpNotFound();
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", goliveChecklist.SiteLocationId);
            return View(goliveChecklist);
        }

        // POST: GoliveChecklists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GoliveChecklistId,GoliveChecklistUsersIdentified,GoliveChecklistUsersIdentifiedDate,GoliveChecklistUsersTrained,GoliveChecklistUsersTrainedDate,GoliveChecklistUsersSetup,GoliveChecklistUsersSetupDate,GoliveChecklistIdentified,GoliveChecklistIdentifiedDate,GoliveChecklistAgreedUse,GoliveChecklistAgreedUseDate,GoliveChecklistSetupCurrent,GoliveChecklistSetupCurrentDate,GoliveChecklistSetupNew,GoliveChecklistSetupNewDate,GoliveChecklistPrescribing,GoliveChecklistPrescribingDate,GoliveChecklistMedAdmin,GoliveChecklistMedAdminDate,GoliveChecklistPharmCheck,GoliveChecklistPharmCheckDate,GoliveChecklistContingencyAgreed,GoliveChecklistContingencyAgreedDate,GoliveChecklistGo_Nogo,GoliveChecklistGo_NogoDate,GoliveChecklistGeneralNotes,SiteLocationId")] GoliveChecklist goliveChecklist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goliveChecklist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", goliveChecklist.SiteLocationId);
            return View(goliveChecklist);
        }

        // GET: GoliveChecklists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoliveChecklist goliveChecklist = db.GoliveChecklists.Find(id);
            if (goliveChecklist == null)
            {
                return HttpNotFound();
            }
            return View(goliveChecklist);
        }

        // POST: GoliveChecklists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GoliveChecklist goliveChecklist = db.GoliveChecklists.Find(id);
            db.GoliveChecklists.Remove(goliveChecklist);
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
