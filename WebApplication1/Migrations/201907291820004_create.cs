namespace HEPMAwebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreaOfCares",
                c => new
                    {
                        AoCId = c.Int(nullable: false, identity: true),
                        SiteLocationId = c.Int(nullable: false),
                        InScope = c.Boolean(nullable: false),
                        AoCName = c.String(),
                        AoCType = c.String(),
                        AoCDescription = c.String(),
                        AoCPlannedGoLiveDate = c.DateTime(),
                        AoCPlannedGoLiveDateAgreedAoC = c.Boolean(nullable: false),
                        AoCRecordOpened = c.DateTime(),
                        AoCRecordClosed = c.DateTime(),
                        AoCFirstContactDate = c.DateTime(),
                        AoCLive = c.Boolean(nullable: false),
                        AoCLiveDate = c.DateTime(),
                        AoCBaU = c.Boolean(nullable: false),
                        AoCBaUDate = c.DateTime(),
                        AoCOnHold = c.Boolean(nullable: false),
                        AoConHoldReason = c.String(),
                        NoLongerInScope = c.Boolean(nullable: false),
                        NoLongerInScopeReason = c.String(),
                        AoCMedicinesReconciliation = c.Boolean(nullable: false),
                        AoCMedicinesReconciliationRealTime = c.Boolean(nullable: false),
                        AoCOutpatientClinicManagedOnTrak = c.Boolean(nullable: false),
                        AoCOutpatientClinicManagedOnTrakInRealTime = c.Boolean(nullable: false),
                        AoCADTsManagedOnTrak = c.Boolean(nullable: false),
                        AoCADTsManagedOnTraIInRealTime = c.Boolean(nullable: false),
                        AoCIDLsProducedInTrak = c.Boolean(nullable: false),
                        AoCIDLsProducedInTrakInRealTime = c.Boolean(nullable: false),
                        AoCWardRounds = c.Boolean(nullable: false),
                        AoCDoctorsRoom = c.Boolean(nullable: false),
                        AoCNursesStation = c.Boolean(nullable: false),
                        AoCOffice = c.Boolean(nullable: false),
                        AoCOfficeText = c.String(),
                        AoCPOther = c.Boolean(nullable: false),
                        AoCPOtherText = c.String(),
                        AoCDrugRoundAtBedside = c.Boolean(nullable: false),
                        AoCDrugRoundFromCentralPoint = c.Boolean(nullable: false),
                        AoCPatientComesToCentralPoint = c.Boolean(nullable: false),
                        AoCMAOther = c.Boolean(nullable: false),
                        AoCMAOtherText = c.String(),
                        AoCBedside = c.Boolean(nullable: false),
                        AoCCentralPointInWard = c.Boolean(nullable: false),
                        AoCPCOher = c.Boolean(nullable: false),
                        AoCPCOtherText = c.String(),
                        AoCAssessmentGoodToGo = c.Boolean(nullable: false),
                        AoCAssessmentGoodToGoDate = c.DateTime(),
                        AoCAssessmentITLiteracy = c.String(),
                        AoCAssessmentUseOfTrak = c.String(),
                        AoCAssessmentHardwareQuality = c.String(),
                        AoCAssessmentHardwareLocation = c.String(),
                        AoCAssessmentBusinessProcessDifference = c.String(),
                        AoCAssessmentGeneralNotes = c.String(),
                        GoliveChecklistUsersIdentified = c.Boolean(nullable: false),
                        GoliveChecklistUsersIdentifiedDate = c.DateTime(),
                        GoliveChecklistUsersTrained = c.Boolean(nullable: false),
                        GoliveChecklistUsersTrainedDate = c.DateTime(),
                        GoliveChecklistUsersSetup = c.Boolean(nullable: false),
                        GoliveChecklistUsersSetupDate = c.DateTime(),
                        GoliveChecklistAgreedUse = c.Boolean(nullable: false),
                        GoliveChecklistAgreedUseDate = c.DateTime(),
                        GoliveChecklistSetupCurrent = c.Boolean(nullable: false),
                        GoliveChecklistSetupCurrentDate = c.DateTime(),
                        GoliveChecklistSetupNew = c.Boolean(nullable: false),
                        GoliveChecklistSetupNewDate = c.DateTime(),
                        GoliveChecklistPrescribing = c.Boolean(nullable: false),
                        GoliveChecklistPrescribingDate = c.DateTime(),
                        GoliveChecklistMedAdmin = c.Boolean(nullable: false),
                        GoliveChecklistMedAdminDate = c.DateTime(),
                        GoliveChecklistPharmCheck = c.Boolean(nullable: false),
                        GoliveChecklistPharmCheckDate = c.DateTime(),
                        GoliveChecklistContingencyAgreed = c.Boolean(nullable: false),
                        GoliveChecklistContingencyAgreedDate = c.DateTime(),
                        GoliveChecklistGo_Nogo = c.Boolean(nullable: false),
                        GoliveChecklistGo_NogoDate = c.DateTime(),
                        GoliveChecklistGeneralNotes = c.String(),
                        BaUChecklistSuccessfulGoLive = c.Boolean(nullable: false),
                        BaUChecklistSuccessfulGoliveNotes = c.String(),
                        BaUChecklistTrainingComplete = c.Boolean(nullable: false),
                        BaUChecklistTrainingCompleteNotes = c.String(),
                        BaUChecklistUserSetup = c.Boolean(nullable: false),
                        BaUChecklisUserSetupNotes = c.String(),
                        BaUChecklistHardwareSetup = c.Boolean(nullable: false),
                        BaUChecklistHardwareSetupNotes = c.String(),
                        BaUChecklistHardwareUseAgreed = c.Boolean(nullable: false),
                        BaUChecklistHardwareUseAgreedNotes = c.String(),
                        BaUChecklistContingencyAgreed = c.Boolean(nullable: false),
                        BaUChecklistContingencyAgreedNotes = c.String(),
                        SiteLocation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.AoCId)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocation_Id)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId)
                .Index(t => t.SiteLocation_Id);
            
            CreateTable(
                "dbo.SiteLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descrption = c.String(),
                        Notes = c.String(),
                        HospitalSiteId = c.Int(),
                        AreaOfCare_AoCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HospitalSites", t => t.HospitalSiteId)
                .ForeignKey("dbo.AreaOfCares", t => t.AreaOfCare_AoCId)
                .Index(t => t.HospitalSiteId)
                .Index(t => t.AreaOfCare_AoCId);
            
            CreateTable(
                "dbo.HospitalSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        PlannedStart = c.DateTime(),
                        PlannedComplete = c.DateTime(),
                        AccommodationComplimentStandardBed = c.Int(),
                        AccommodationComplimentDaySurgeryBed = c.Int(),
                        AccommodationComplimentTrolly = c.Int(),
                        AccommodationComplimentChair = c.Int(),
                        AccommodationComplimentSpecialCareBabyUnitCot = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hardwares",
                c => new
                    {
                        HId = c.Int(nullable: false, identity: true),
                        HType = c.String(),
                        HAssetNumber = c.String(),
                        HMacAddress = c.String(),
                        HNetworkPort = c.String(),
                        HNPInUse = c.Boolean(nullable: false),
                        HElectricalSocket = c.String(),
                        HESInUse = c.Boolean(nullable: false),
                        HTrailingSocket = c.Boolean(nullable: false),
                        HLoIId = c.Int(nullable: false),
                        LocationOfInterest_LoIId = c.Int(),
                    })
                .PrimaryKey(t => t.HId)
                .ForeignKey("dbo.LocationOfInterests", t => t.LocationOfInterest_LoIId)
                .Index(t => t.LocationOfInterest_LoIId);
            
            CreateTable(
                "dbo.LocationOfInterests",
                c => new
                    {
                        LoIId = c.Int(nullable: false, identity: true),
                        LoIName = c.String(),
                        LoIRoomReference = c.String(),
                        LoIDescription = c.String(),
                        LoIPrescribing = c.Boolean(nullable: false),
                        LoIMedicinesAdministration = c.Boolean(nullable: false),
                        LoIPharmacyCheck = c.Boolean(nullable: false),
                        LoINotes = c.String(),
                        LoIAoCId = c.Int(nullable: false),
                        AreaOfCare_AoCId = c.Int(),
                    })
                .PrimaryKey(t => t.LoIId)
                .ForeignKey("dbo.AreaOfCares", t => t.AreaOfCare_AoCId)
                .Index(t => t.AreaOfCare_AoCId);
            
            CreateTable(
                "dbo.NotesFieldHospitalSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        HospitalId = c.Int(nullable: false),
                        Note = c.String(),
                        HospitalSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HospitalSites", t => t.HospitalSite_Id)
                .Index(t => t.HospitalSite_Id);
            
            CreateTable(
                "dbo.NotesFieldSiteLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        SiteLocationId = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId);
            
            CreateTable(
                "dbo.NotesFieldAreaOfCares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        AoCId = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaOfCares", t => t.AoCId, cascadeDelete: true)
                .Index(t => t.AoCId);
            
            CreateTable(
                "dbo.NotesFieldLocationOfInterests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        LoIId = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LocationOfInterests", t => t.LoIId, cascadeDelete: true)
                .Index(t => t.LoIId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldLocationOfInterests", "LoIId", "dbo.LocationOfInterests");
            DropForeignKey("dbo.NotesFieldAreaOfCares", "AoCId", "dbo.AreaOfCares");
            DropForeignKey("dbo.NotesFieldSiteLocations", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.NotesFieldHospitalSites", "HospitalSite_Id", "dbo.HospitalSites");
            DropForeignKey("dbo.Hardwares", "LocationOfInterest_LoIId", "dbo.LocationOfInterests");
            DropForeignKey("dbo.LocationOfInterests", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropForeignKey("dbo.SiteLocations", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "HospitalSiteId", "dbo.HospitalSites");
            DropForeignKey("dbo.AreaOfCares", "SiteLocation_Id", "dbo.SiteLocations");
            DropIndex("dbo.NotesFieldLocationOfInterests", new[] { "LoIId" });
            DropIndex("dbo.NotesFieldAreaOfCares", new[] { "AoCId" });
            DropIndex("dbo.NotesFieldSiteLocations", new[] { "SiteLocationId" });
            DropIndex("dbo.NotesFieldHospitalSites", new[] { "HospitalSite_Id" });
            DropIndex("dbo.LocationOfInterests", new[] { "AreaOfCare_AoCId" });
            DropIndex("dbo.Hardwares", new[] { "LocationOfInterest_LoIId" });
            DropIndex("dbo.SiteLocations", new[] { "AreaOfCare_AoCId" });
            DropIndex("dbo.SiteLocations", new[] { "HospitalSiteId" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocation_Id" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocationId" });
            DropTable("dbo.NotesFieldLocationOfInterests");
            DropTable("dbo.NotesFieldAreaOfCares");
            DropTable("dbo.NotesFieldSiteLocations");
            DropTable("dbo.NotesFieldHospitalSites");
            DropTable("dbo.LocationOfInterests");
            DropTable("dbo.Hardwares");
            DropTable("dbo.HospitalSites");
            DropTable("dbo.SiteLocations");
            DropTable("dbo.AreaOfCares");
        }
    }
}
