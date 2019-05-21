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
    public class AreasOfCareTestController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: AreasOfCareTest
        public ActionResult Index()
        {
            var areasOfCare = db.AreasOfCare.Include(a => a.SiteLocation);
            return View(areasOfCare.ToList());
        }

        // GET: AreasOfCareTest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AreaOfCare areaOfCare = db.AreasOfCare.Find(id);
            if (areaOfCare == null)
            {
                return HttpNotFound();
            }
            return View(areaOfCare);
        }

        // GET: AreasOfCareTest/Create
        public ActionResult Create()
        {
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name");
            return View();
        }

        // POST: AreasOfCareTest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AoCId,SiteLocationId,AoCName,AoCType,AoCDescription,AoCImplementationOrder,AoCRecordOpened,AoCRecordClosed,AoCFirstContact,AoCFirstContactDate,AoCLive,AoCLiveDate,AoCBaU,AoCBaUDate,AoCOnHold,AoConHoldReason,AoCMedicinesReconciliation,AoCMedicinesReconciliationRealTime,AoCOutpatientClinicManagedOnTrak,AoCOutpatientClinicManagedOnTrakInRealTime,AoCADTsManagedOnTrak,AoCADTsManagedOnTraIInRealTime,AoCIDLsProducedInTrak,AoCIDLsProducedInTrakInRealTime,AoCWardRounds,AoCDoctorsRoom,AoCNursesStation,AoCOffice,AoCOfficeText,AoCPOther,AoCPOtherText,AoCDrugRoundAtBedside,AoCDrugRoundFromCentralPoint,AoCPatientComesToCentralPoint,AoCMAOther,AoCMAOtherText,AoCBedside,AoCCentralPointInWard,AoCPCOher,AoCPCOtherText")] AreaOfCare areaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.AreasOfCare.Add(areaOfCare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", areaOfCare.SiteLocationId);
            return View(areaOfCare);
        }

        // GET: AreasOfCareTest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AreaOfCare areaOfCare = db.AreasOfCare.Find(id);
            if (areaOfCare == null)
            {
                return HttpNotFound();
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", areaOfCare.SiteLocationId);
            return View(areaOfCare);
        }

        // POST: AreasOfCareTest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AoCId,SiteLocationId,AoCName,AoCType,AoCDescription,AoCImplementationOrder,AoCRecordOpened,AoCRecordClosed,AoCFirstContact,AoCFirstContactDate,AoCLive,AoCLiveDate,AoCBaU,AoCBaUDate,AoCOnHold,AoConHoldReason,AoCMedicinesReconciliation,AoCMedicinesReconciliationRealTime,AoCOutpatientClinicManagedOnTrak,AoCOutpatientClinicManagedOnTrakInRealTime,AoCADTsManagedOnTrak,AoCADTsManagedOnTraIInRealTime,AoCIDLsProducedInTrak,AoCIDLsProducedInTrakInRealTime,AoCWardRounds,AoCDoctorsRoom,AoCNursesStation,AoCOffice,AoCOfficeText,AoCPOther,AoCPOtherText,AoCDrugRoundAtBedside,AoCDrugRoundFromCentralPoint,AoCPatientComesToCentralPoint,AoCMAOther,AoCMAOtherText,AoCBedside,AoCCentralPointInWard,AoCPCOher,AoCPCOtherText")] AreaOfCare areaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(areaOfCare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", areaOfCare.SiteLocationId);
            return View(areaOfCare);
        }

        // GET: AreasOfCareTest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AreaOfCare areaOfCare = db.AreasOfCare.Find(id);
            if (areaOfCare == null)
            {
                return HttpNotFound();
            }
            return View(areaOfCare);
        }

        // POST: AreasOfCareTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AreaOfCare areaOfCare = db.AreasOfCare.Find(id);
            db.AreasOfCare.Remove(areaOfCare);
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
