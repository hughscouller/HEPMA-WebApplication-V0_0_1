using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models.HEPMA;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "ProjectTeam, Admin")]
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

            // ////////////////////////////////////////////////////

            List<NotesFieldAreaOfCare> AoCNotes = new List<NotesFieldAreaOfCare>(db.NotesFieldAreaOfCares.Where(aocn => aocn.AoCId == areaOfCare.AoCId).ToList().OrderByDescending(aocn => aocn.CreatedOn));

            ViewBag.AoCNotes = AoCNotes;
            //ViewBag.SiteLocation = siteLocation.Name;
            //ViewBag.HospitalSiteName = hospitalSite.Name;
            //ViewBag.HospitalSiteId = hospitalSite.Id;


            //List<LocationOfInterest> locationsOfInterest = new List<LocationOfInterest>;

            // find all SiteLocations where HospitalSiteId = id ////
            var locationsOfInterest = db.LocationOfInterest
                    .Where(loi => loi.LoIAoCId == id);

            ViewBag.locationsOfInterest = locationsOfInterest;

            int count = 0;
            foreach (var loi in locationsOfInterest)
            {
                count++;
            }
            ViewBag.locationsOfInterestCount = count;
            ////////////////////////////////////////////////////////

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InScope,AoCId,SiteLocationId,AoCName,AoCType,AoCDescription,AoCPlannedGoLiveDate,AoCPlannedGoLiveDateAgreedAoC,AoCRecordOpened,AoCRecordClosed,AoCFirstContactDate,AoCLive,AoCLiveDate,AoCBaU,AoCBaUDate,AoCOnHold,AoConHoldReason,NoLongerInScope,NoLongerInScopeReason,AoCMedicinesReconciliation,AoCMedicinesReconciliationRealTime,AoCOutpatientClinicManagedOnTrak,AoCOutpatientClinicManagedOnTrakInRealTime,AoCADTsManagedOnTrak,AoCADTsManagedOnTraIInRealTime,AoCIDLsProducedInTrak,AoCIDLsProducedInTrakInRealTime,AoCWardRounds,AoCDoctorsRoom,AoCNursesStation,AoCOffice,AoCOfficeText,AoCPOther,AoCPOtherText,AoCDrugRoundAtBedside,AoCDrugRoundFromCentralPoint,AoCPatientComesToCentralPoint,AoCMAOther,AoCMAOtherText,AoCBedside,AoCCentralPointInWard,AoCPCOher,AoCPCOtherText")] AreaOfCare areaOfCare)
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
        public ActionResult Edit([Bind(Include = "InScope,AoCId,SiteLocationId,AoCName,AoCType,AoCDescription,AoCPlannedGoLiveDate, AoCPlannedGoLiveDateAgreedAoC,AoCRecordOpened,AoCRecordClosed,AoCFirstContactDate,AoCLive,AoCLiveDate,AoCBaU,AoCBaUDate,AoCOnHold,AoConHoldReason,NoLongerInScope,NoLongerInScopeReason,AoCMedicinesReconciliation,AoCMedicinesReconciliationRealTime,AoCOutpatientClinicManagedOnTrak,AoCOutpatientClinicManagedOnTrakInRealTime,AoCADTsManagedOnTrak,AoCADTsManagedOnTraIInRealTime,AoCIDLsProducedInTrak,AoCIDLsProducedInTrakInRealTime,AoCWardRounds,AoCDoctorsRoom,AoCNursesStation,AoCOffice,AoCOfficeText,AoCPOther,AoCPOtherText,AoCDrugRoundAtBedside,AoCDrugRoundFromCentralPoint,AoCPatientComesToCentralPoint,AoCMAOther,AoCMAOtherText,AoCBedside,AoCCentralPointInWard,AoCPCOher,AoCPCOtherText,AoCAssessmentGoodToGo,AoCAssessmentGoodToGoDate,AoCAssessmentITLiteracy,AoCAssessmentUseOfTrak,AoCAssessmentHardwareQuality,AoCAssessmentHardwareLocation,AoCAssessmentBusinessProcessDifference,AoCAssessmentGeneralNotes,GoliveChecklistUsersIdentified,GoliveChecklistUsersIdentifiedDate,GoliveChecklistUsersTrained,GoliveChecklistUsersTrainedDate,GoliveChecklistUsersSetup,GoliveChecklistUsersSetupDate,GoliveChecklistAgreedUse,GoliveChecklistAgreedUseDate,GoliveChecklistSetupCurrent,GoliveChecklistSetupCurrentDate,GoliveChecklistSetupNew,GoliveChecklistSetupNewDate,GoliveChecklistPrescribing,GoliveChecklistPrescribingDate,GoliveChecklistMedAdmin,GoliveChecklistMedAdminDate,GoliveChecklistPharmCheck,GoliveChecklistPharmCheckDate,GoliveChecklistContingencyAgreed,GoliveChecklistContingencyAgreedDate,GoliveChecklistGo_Nogo,GoliveChecklistGo_NogoDate,GoliveChecklistGeneralNotes,BaUChecklistHardwareSetup,BaUChecklistSuccessfulGoLive,BaUChecklistSuccessfulGoliveNotes,BaUChecklistTrainingComplete,BaUChecklistTrainingCompleteNotes,BaUChecklistUserSetup,BaUChecklisUserSetupNotes,BaUChecklistHardwareSetupNotes,BaUChecklistHardwareUseAgreed,BaUChecklistHardwareUseAgreedNotes,BaUChecklistContingencyAgreed,BaUChecklistContingencyAgreedNotes")] AreaOfCare areaOfCare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(areaOfCare).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("../SiteLocations/Details", new { id = areaOfCare.SiteLocationId });
                return RedirectToAction("Details", new { id = areaOfCare.AoCId });
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
