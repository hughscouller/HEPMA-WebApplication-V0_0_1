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
    public class SiteLocationsController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: SiteLocations
        public ActionResult Index()
        {
            var siteLocations = db.SiteLocations.Include(s => s.HospitalSite);
            return View(siteLocations.ToList());
        }

        // GET: SiteLocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteLocation siteLocation = db.SiteLocations.Find(id);
            // ////////////////////////////////////////////////
            var hospitalSiteName = db.HospitalSites
                    .Where(HS => HS.Id == siteLocation.HospitalSiteId);

            ViewBag.HospitalSiteName = hospitalSiteName.First().Name;

            // ////////////////////////////////////////////////
            // find all SiteLocations where HospitalSiteId = id
            var AreasOfCare = db.AreasOfCare
                    .Where(AoC => AoC.SiteLocationId == id)
                    .OrderBy(g => g.AoCPlannedGoLiveDate);


            ViewBag.AreasOfCare = AreasOfCare;

            ViewBag.AreasOfCareCount = AreasOfCare.Count();
            // //////////////////////////////////////////////////
            

            if (siteLocation == null)
            {
                return HttpNotFound();
            }
            return View(siteLocation);
        }

        // GET: SiteLocations/Create
        public ActionResult Create(int? id)
        {
            // ViewBag.HospitalSiteId = new SelectList(db.HospitalSites, "Id", "Name");  // required for the HospitalSite dropdown form field
            ViewBag.HospitalSiteId = new SelectList(db.HospitalSites, "Id", "Name");



            var SL = new SiteLocation();
            SL.HospitalSiteId = id;
            //ViewBag.HSID = id;

            return View(SL);
        }

        // POST: SiteLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Descrption,Notes,HospitalSiteId")] SiteLocation siteLocation)
        {
            if (ModelState.IsValid)
            {
                db.SiteLocations.Add(siteLocation);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction("../HospitalSites/Details", new { id = siteLocation.HospitalSiteId });
            }

            ViewBag.HospitalSiteId = new SelectList(db.HospitalSites, "Id", "Name", siteLocation.HospitalSiteId);
            return View(siteLocation);
            //return RedirectToAction("../HospitalSites/Details", new { id = siteLocation.Id });
        }

        // GET: SiteLocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteLocation siteLocation = db.SiteLocations.Find(id);
            if (siteLocation == null)
            {
                return HttpNotFound();
            }
            ViewBag.HospitalSiteId = new SelectList(db.HospitalSites, "Id", "Name", siteLocation.HospitalSiteId);
            return View(siteLocation);
            
        }

        // POST: SiteLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Descrption,Notes,HospitalSiteId")] SiteLocation siteLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteLocation).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction("../HospitalSites/Details/", new { id = siteLocation.HospitalSiteId });
            }
            ViewBag.HospitalSiteId = new SelectList(db.HospitalSites, "Id", "Name", siteLocation.HospitalSiteId);
            return View(siteLocation);
            
        }

        // GET: AreasOfCare/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteLocation siteLocation = db.SiteLocations.Find(id);
            if (siteLocation == null)
            {
                return HttpNotFound();
            }
            return View(siteLocation);
        }

        // POST: AreasOfCare/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SiteLocation siteLocation = db.SiteLocations.Find(id);
            var HSid = siteLocation.HospitalSiteId;
            db.SiteLocations.Remove(siteLocation);
            db.SaveChanges();

            return RedirectToAction("../HospitalSites/Details/", new { id = HSid });
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
