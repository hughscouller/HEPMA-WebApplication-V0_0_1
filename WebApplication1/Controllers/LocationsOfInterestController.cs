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
    public class LocationsOfInterestController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: LocationsOfInterest
        public ActionResult Index()
        {
            return View(db.LocationOfInterests.ToList());
        }

        // GET: LocationsOfInterest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFeildLocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
            if (locationOfInterest == null)
            {
                return HttpNotFound();
            }

            // ///////////////////////////////////////////////////////
            AreaOfCare areaOfCare = db.AreasOfCare.Find(locationOfInterest.LoIAoCId);
            SiteLocation siteLocation = db.SiteLocations.Find(areaOfCare.SiteLocationId);
            HospitalSite hospitalSite = db.HospitalSites.Find(siteLocation.HospitalSiteId);

            //List<NotesFieldLocationOfInterest> notesFieldLocationOfInterest = db.NotesFieldLocationOfInterests.Find(locationOfInterest.LoIId);
            List<NotesFieldLocationOfInterest> notesFieldLocationOfInterest = new List<NotesFieldLocationOfInterest>(db.NotesFieldLocationOfInterests.Where(loin => loin.LoIId == locationOfInterest.LoIId).ToList().OrderByDescending(loin => loin.CreatedOn));

            ViewBag.HospitalSite = hospitalSite;
            ViewBag.HospitalSiteID = siteLocation.HospitalSiteId;
            ViewBag.siteLocationName = siteLocation.Name;
            ViewBag.siteLocationID = siteLocation.Id;
            ViewBag.areaOfCareName = areaOfCare.AoCName;

            ViewBag.LocationOfInterestNotes = notesFieldLocationOfInterest;

            var hardware = db.Hardwares
                .Where(H => H.HLoIId == id);

            ViewBag.Hardware = hardware;

            ////////////////////////////////////////////////////////
            // //////////////////////////////////////////////////////

            return View(locationOfInterest);
        }

        // GET: LocationsOfInterest/Create
        public ActionResult Create(int id)
        {
            NotesFeildLocationOfInterest locationOfInterest = new NotesFeildLocationOfInterest();
            locationOfInterest.LoIAoCId = id;

            return View(locationOfInterest);
        }

        // POST: LocationsOfInterest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoIId,LoIName,LoIRoomReference,LoIDescription,LoIPrescribing,LoIMedicinesAdministration,LoIPharmacyCheck,LoINotes,LoIAoCId")] NotesFeildLocationOfInterest locationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.LocationOfInterests.Add(locationOfInterest);
                db.SaveChanges();
                return RedirectToAction("../AreasOfCare/Details/", new { id = locationOfInterest.LoIAoCId });
            }

            return View(locationOfInterest);
        }

        // GET: LocationsOfInterest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFeildLocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
            if (locationOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(locationOfInterest);
        }

        // POST: LocationsOfInterest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoIId,LoIName,LoIRoomReference,LoIDescription,LoIPrescribing,LoIMedicinesAdministration,LoIPharmacyCheck,LoINotes,LoIAoCId")] NotesFeildLocationOfInterest locationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locationOfInterest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("../AreasOfCare/Details/", new { id = locationOfInterest.LoIAoCId });
            }
            return View(locationOfInterest);
        }

        // GET: LocationsOfInterest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesFeildLocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
            if (locationOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(locationOfInterest);
        }

        // POST: LocationsOfInterest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesFeildLocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
            db.LocationOfInterests.Remove(locationOfInterest);
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
