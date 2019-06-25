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
            LocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
            if (locationOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(locationOfInterest);
        }

        // GET: LocationsOfInterest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationsOfInterest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoIId,LoIName,LoIRoomReference,LoIDescription,LoIPrescribing,LoIMedicinesAdministration,LoIPharmacyCheck,LoINotes,LoIAoCId")] LocationOfInterest locationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.LocationOfInterests.Add(locationOfInterest);
                db.SaveChanges();
                return RedirectToAction("Index");
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
            LocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
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
        public ActionResult Edit([Bind(Include = "LoIId,LoIName,LoIRoomReference,LoIDescription,LoIPrescribing,LoIMedicinesAdministration,LoIPharmacyCheck,LoINotes,LoIAoCId")] LocationOfInterest locationOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locationOfInterest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
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
            LocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
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
            LocationOfInterest locationOfInterest = db.LocationOfInterests.Find(id);
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
