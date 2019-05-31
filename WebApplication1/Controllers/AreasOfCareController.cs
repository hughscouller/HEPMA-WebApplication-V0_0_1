﻿using System;
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
    public class AreasOfCareController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: AreasOfCare
        public ActionResult Index()
        {
            var areasOfCare = db.AreasOfCare.Include(a => a.SiteLocation);
            return View(areasOfCare.ToList());
        }

        // GET: AreasOfCare/Details/5
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

            SiteLocation siteLocation = db.SiteLocations.Find(areaOfCare.SiteLocationId);
            HospitalSite hospitalSite = db.HospitalSites.Find(siteLocation.Id);
            ViewBag.SiteLocation = siteLocation.Name;

            return View(areaOfCare);
        }

        // GET: AreasOfCare/Create
        public ActionResult Create(int id)
        {

            AreaOfCare areaOfCare = new AreaOfCare(); //db.AreasOfCare.Find(id);
            areaOfCare.SiteLocationId = id;

            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", areaOfCare.SiteLocationId);
            return View(areaOfCare);
        }

        // POST: AreasOfCare/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InScope,AoCId,SiteLocationId,AoCName,AoCType,AoCDescription,AoCPlannedGoLiveDate,AoCPlannedGoLiveDateAgreedAoC,AoCRecordOpened,AoCRecordClosed,AoCFirstContact,AoCFirstContactDate,AoCLive,AoCLiveDate,AoCBaU,AoCBaUDate,AoCOnHold,AoConHoldReason,NoLongerInScope,NoLongerInScopeReason,AoCMedicinesReconciliation,AoCMedicinesReconciliationRealTime,AoCOutpatientClinicManagedOnTrak,AoCOutpatientClinicManagedOnTrakInRealTime,AoCADTsManagedOnTrak,AoCADTsManagedOnTraIInRealTime,AoCIDLsProducedInTrak,AoCIDLsProducedInTrakInRealTime,AoCWardRounds,AoCDoctorsRoom,AoCNursesStation,AoCOffice,AoCOfficeText,AoCPOther,AoCPOtherText,AoCDrugRoundAtBedside,AoCDrugRoundFromCentralPoint,AoCPatientComesToCentralPoint,AoCMAOther,AoCMAOtherText,AoCBedside,AoCCentralPointInWard,AoCPCOher,AoCPCOtherText")] AreaOfCare areaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.AreasOfCare.Add(areaOfCare);
                db.SaveChanges();
                //// /////////////////////////////////////////////////
                //AoCAssessment AoCA = new AoCAssessment();
                //AoCA.AoCAssessmentId = areaOfCare.SiteLocationId;
                //db.AoCAssessments.Add(AoCA);
                //// ///////////////////////////////////////////////////
                //// /////////////////////////////////////////////////
                //GoliveChecklist GLCL = new GoliveChecklist();
                //GLCL.GoliveChecklistId = areaOfCare.SiteLocationId;
                //db.AoCAssessments.Add(AoCA);
                //// ///////////////////////////////////////////////////
                //// /////////////////////////////////////////////////
                //BaUChecklist BaUC = new BaUChecklist();
                //GLCL.SiteLocationId = areaOfCare.SiteLocationId;
                //db.AoCAssessments.Add(AoCA);
                //// ///////////////////////////////////////////////////


                return RedirectToAction("../SiteLocations/Details", new { id = areaOfCare.SiteLocationId });
            }

            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", areaOfCare.SiteLocationId);
            return View(areaOfCare);
        }

        // GET: AreasOfCare/Edit/5
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

        // POST: AreasOfCare/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InScope,AoCId,SiteLocationId,AoCName,AoCType,AoCDescription,AoCPlannedGoLiveDate, AoCPlannedGoLiveDateAgreedAoC,AoCRecordOpened,AoCRecordClosed,AoCFirstContact,AoCFirstContactDate,AoCLive,AoCLiveDate,AoCBaU,AoCBaUDate,AoCOnHold,AoConHoldReason,NoLongerInScope,NoLongerInScopeReason,AoCMedicinesReconciliation,AoCMedicinesReconciliationRealTime,AoCOutpatientClinicManagedOnTrak,AoCOutpatientClinicManagedOnTrakInRealTime,AoCADTsManagedOnTrak,AoCADTsManagedOnTraIInRealTime,AoCIDLsProducedInTrak,AoCIDLsProducedInTrakInRealTime,AoCWardRounds,AoCDoctorsRoom,AoCNursesStation,AoCOffice,AoCOfficeText,AoCPOther,AoCPOtherText,AoCDrugRoundAtBedside,AoCDrugRoundFromCentralPoint,AoCPatientComesToCentralPoint,AoCMAOther,AoCMAOtherText,AoCBedside,AoCCentralPointInWard,AoCPCOher,AoCPCOtherText")] AreaOfCare areaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(areaOfCare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("../SiteLocations/Details", new { id = areaOfCare.SiteLocationId });
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", areaOfCare.SiteLocationId);
            return View(areaOfCare);
            //return RedirectToAction("../SiteLocation/Details", new { id = areaOfCare.SiteLocationId });
        }

        // GET: AreasOfCare/Delete/5
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

        // POST: AreasOfCare/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AreaOfCare areaOfCare = db.AreasOfCare.Find(id);
            db.AreasOfCare.Remove(areaOfCare);
            db.SaveChanges();
            return RedirectToAction("../SiteLocations/Details", new { id = areaOfCare.SiteLocationId });
            //return RedirectToAction("Index");
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
