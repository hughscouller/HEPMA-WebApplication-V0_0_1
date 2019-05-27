namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
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
                        AoCFirstContact = c.Boolean(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldHospitalSites", "HospitalSite_Id", "dbo.HospitalSites");
            DropForeignKey("dbo.SiteLocations", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "HospitalSiteId", "dbo.HospitalSites");
            DropForeignKey("dbo.AreaOfCares", "SiteLocation_Id", "dbo.SiteLocations");
            DropIndex("dbo.NotesFieldHospitalSites", new[] { "HospitalSite_Id" });
            DropIndex("dbo.SiteLocations", new[] { "AreaOfCare_AoCId" });
            DropIndex("dbo.SiteLocations", new[] { "HospitalSiteId" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocation_Id" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocationId" });
            DropTable("dbo.NotesFieldHospitalSites");
            DropTable("dbo.HospitalSites");
            DropTable("dbo.SiteLocations");
            DropTable("dbo.AreaOfCares");
        }
    }
}
