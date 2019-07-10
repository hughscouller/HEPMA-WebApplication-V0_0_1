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
    public class HospitalSitesController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: HospitalSites
        //[Authorize]
        public ActionResult Index()
        {
            return View(db.HospitalSites.ToList());
        }

        // GET: HospitalSites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalSite hospitalSite = db.HospitalSites.Find(id);

            if (hospitalSite == null)
            {
                return HttpNotFound();
            }

            // find all SiteLocations where HospitalSiteId = id ////
            var siteLocations = db.SiteLocations
                    .Where(sl => sl.HospitalSiteId == id);

            ViewBag.SiteLocations = siteLocations;
            ViewBag.SiteLocationsCount = siteLocations.Count();
            ////////////////////////////////////////////////////////
            
            // Areas of Care information //////////////////////////
            List<AreaOfCare> areasOfCare = db.AreasOfCare.ToList();

            List<int> aocCount = new List<int>();
            foreach(var sl in siteLocations)
            {
                aocCount.Add(siteLocationAoCsCount(areasOfCare, sl.Id));
            }
            ViewBag.AreaOfCareCount = aocCount;
            // ////////////////////////////////////////////////////

            List<NotesFieldHospitalSite> HospitalNotesBag = new List<NotesFieldHospitalSite> (db.HospitalNotes.Where(hn => hn.HospitalId == hospitalSite.Id ).ToList().OrderByDescending(hn => hn.CreatedOn) );

            ViewBag.HospitalNotes = HospitalNotesBag;

            return View(hospitalSite);
        }

        // helper functions ////////////////////////////////////////////////////
        // count of AoCs in given SiteLocation ////////////////////////////////
        private int siteLocationAoCsCount(List<AreaOfCare> aocs, int SLId)
        {
            int count = 0;

            foreach(var aoc in aocs)
            {
                if(aoc.SiteLocationId == SLId)
                {
                    count++;
                }
            }

            return count;
        }

        // end helper function - Details Post ////////////////////////////////////////////////
        // ////////////////////////////////////////////////////////////////////


        // GET: HospitalSites/Create
        public ActionResult Create()
        {
            //ViewBag.HospitalSiteIdForCreate = HSId;
            return View();
        }

        // POST: HospitalSites/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Notes,PlannedStart, PlannedComplete, AccommodationComplimentStandardBed, AccommodationComplimentDaySurgeryBed, AccommodationComplimentTrolly, AccommodationComplimentChair, AccommodationComplimentSpecialCareBabyUnitCot")] HospitalSite hospitalSite)
        {
            if (ModelState.IsValid)
            {
                db.HospitalSites.Add(hospitalSite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalSite);
        }

        // GET: HospitalSites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalSite hospitalSite = db.HospitalSites.Find(id);
            if (hospitalSite == null)
            {
                return HttpNotFound();
            }
            return View(hospitalSite);
        }

        // POST: HospitalSites/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Notes,PlannedStart, PlannedComplete, AccommodationComplimentStandardBed, AccommodationComplimentDaySurgeryBed, AccommodationComplimentTrolly, AccommodationComplimentChair, AccommodationComplimentSpecialCareBabyUnitCot")] HospitalSite hospitalSite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalSite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = hospitalSite.Id });
            }
            return View(hospitalSite);
        }

        // GET: HospitalSites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalSite hospitalSite = db.HospitalSites.Find(id);
            if (hospitalSite == null)
            {
                return HttpNotFound();
            }
            return View(hospitalSite);
        }

        // POST: HospitalSites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HospitalSite hospitalSite = db.HospitalSites.Find(id);
            db.HospitalSites.Remove(hospitalSite);
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
