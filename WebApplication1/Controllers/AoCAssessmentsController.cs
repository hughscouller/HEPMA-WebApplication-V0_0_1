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
    public class AoCAssessmentsController : Controller
    {
        private HEPMADbContext db = new HEPMADbContext();

        // GET: AoCAssessments
        public ActionResult Index()
        {
            var aoCAssessments = db.AoCAssessments.Include(a => a.SiteLocation);
            return View(aoCAssessments.ToList());
        }

        // GET: AoCAssessments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AoCAssessment aoCAssessment = db.AoCAssessments.Find(id);
            if (aoCAssessment == null)
            {
                return HttpNotFound();
            }
            return View(aoCAssessment);
        }

        // GET: AoCAssessments/Create
        public ActionResult Create()
        {
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name");
            return View();
        }

        // POST: AoCAssessments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AoCAssessmentId,AoCAssessmentGoodToGo,AoCAssessmentGoodToGoDate,AoCAssessmentITLiteracy,AoCAssessmentUseOfTrak,AoCAssessmentHardwareQuality,AoCAssessmentHardwareQuantity,AoCAssessmentHardwareLocation,AoCAssessmentBusinessProcessDifference,AoCAssessmentGeneralNotes,SiteLocationId")] AoCAssessment aoCAssessment)
        {
            if (ModelState.IsValid)
            {
                db.AoCAssessments.Add(aoCAssessment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", aoCAssessment.SiteLocationId);
            return View(aoCAssessment);
        }

        // GET: AoCAssessments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AoCAssessment aoCAssessment = db.AoCAssessments.Find(id);
            if (aoCAssessment == null)
            {
                return HttpNotFound();
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", aoCAssessment.SiteLocationId);
            return View(aoCAssessment);
        }

        // POST: AoCAssessments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AoCAssessmentId,AoCAssessmentGoodToGo,AoCAssessmentGoodToGoDate,AoCAssessmentITLiteracy,AoCAssessmentUseOfTrak,AoCAssessmentHardwareQuality,AoCAssessmentHardwareQuantity,AoCAssessmentHardwareLocation,AoCAssessmentBusinessProcessDifference,AoCAssessmentGeneralNotes,SiteLocationId")] AoCAssessment aoCAssessment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aoCAssessment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SiteLocationId = new SelectList(db.SiteLocations, "Id", "Name", aoCAssessment.SiteLocationId);
            return View(aoCAssessment);
        }

        // GET: AoCAssessments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AoCAssessment aoCAssessment = db.AoCAssessments.Find(id);
            if (aoCAssessment == null)
            {
                return HttpNotFound();
            }
            return View(aoCAssessment);
        }

        // POST: AoCAssessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AoCAssessment aoCAssessment = db.AoCAssessments.Find(id);
            db.AoCAssessments.Remove(aoCAssessment);
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
