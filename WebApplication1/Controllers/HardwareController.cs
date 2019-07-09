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
    public class HardwareController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: Hardware
        public ActionResult Index()
        {
            return View(db.Hardwares.ToList());
        }

        // GET: Hardware/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hardware hardware = db.Hardwares.Find(id);
            if (hardware == null)
            {
                return HttpNotFound();
            }
            return View(hardware);
        }

        // GET: Hardware/Create
        public ActionResult Create(int id)
        {
            Hardware hardware = new Hardware();
            hardware.HLoIId = id;

            return View(hardware);
        }

        // POST: Hardware/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HId,HType,HAssetNumber,HMacAddress,HNetworkPort,HNPInUse,HElectricalSocket,HESInUse,HTrailingSocket,HLoIId")] Hardware hardware)
        {
            if (ModelState.IsValid)
            {
                db.Hardwares.Add(hardware);
                db.SaveChanges();
                return RedirectToAction("../LocationsOfInterest/Details/", new { id = hardware.HLoIId });
            }

            return View(hardware);
        }

        // GET: Hardware/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hardware hardware = db.Hardwares.Find(id);
            if (hardware == null)
            {
                return HttpNotFound();
            }
            return View(hardware);
        }

        // POST: Hardware/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HId,HType,HAssetNumber,HMacAddress,HNetworkPort,HNPInUse,HElectricalSocket,HESInUse,HTrailingSocket,HLoIId")] Hardware hardware)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hardware).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hardware);
        }

        // GET: Hardware/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hardware hardware = db.Hardwares.Find(id);
            if (hardware == null)
            {
                return HttpNotFound();
            }
            return View(hardware);
        }

        // POST: Hardware/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hardware hardware = db.Hardwares.Find(id);
            db.Hardwares.Remove(hardware);
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
