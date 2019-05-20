namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreaOfCares",
                c => new
                    {
                        AoCId = c.Int(nullable: false, identity: true),
                        SiteLocationId = c.Int(nullable: false),
                        AoCName = c.String(),
                        AoCType = c.String(),
                        AoCDescription = c.String(),
                        AoCImplementationOrder = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.AoCId)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId);
            
            CreateTable(
                "dbo.SiteLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descrption = c.String(),
                        Notes = c.String(),
                        HospitalSiteId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HospitalSites", t => t.HospitalSiteId)
                .Index(t => t.HospitalSiteId);
            
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
                "dbo.NotesFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(),
                        CreatedBy = c.String(),
                        NoteType = c.String(),
                        Note = c.String(),
                        AreaOfCareId = c.Int(nullable: false),
                        AreaOfCare_AoCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaOfCares", t => t.AreaOfCare_AoCId)
                .Index(t => t.AreaOfCare_AoCId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFields", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropForeignKey("dbo.SiteLocations", "HospitalSiteId", "dbo.HospitalSites");
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.NotesFields", new[] { "AreaOfCare_AoCId" });
            DropIndex("dbo.SiteLocations", new[] { "HospitalSiteId" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocationId" });
            DropTable("dbo.NotesFields");
            DropTable("dbo.HospitalSites");
            DropTable("dbo.SiteLocations");
            DropTable("dbo.AreaOfCares");
        }
    }
}
