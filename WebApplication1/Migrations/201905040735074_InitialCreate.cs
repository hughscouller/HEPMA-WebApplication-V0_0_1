namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreasOfCare",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AocType = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        Status = c.String(),
                        FirstContactDate = c.DateTime(),
                        FirstContactNotes = c.String(),
                        PlannedGoLiveDate = c.DateTime(),
                        PlannedGoLiveNotes = c.String(),
                        ActualGoLiveDate = c.DateTime(),
                        ActualGoLiveNotes = c.String(),
                        BauHandoverDate = c.DateTime(),
                        BauHandoverNotes = c.String(),
                        AoCGeneralNotes = c.String(),
                        SiteLocationId = c.Int(nullable: false),
                        ADTs = c.Boolean(nullable: false),
                        ADTsRealTime = c.Boolean(nullable: false),
                        ADTsNotes = c.String(),
                        OPCLinic = c.Boolean(nullable: false),
                        OPClinicRealTIme = c.Boolean(nullable: false),
                        OPClinicNotes = c.String(),
                        MedRec = c.Boolean(nullable: false),
                        MedRecWho = c.String(),
                        MedRecWhere = c.String(),
                        MedRecWhen = c.String(),
                        MedRecNotes = c.String(),
                        PrescWardRounds = c.Boolean(nullable: false),
                        PrescWardRoundsNotes = c.String(),
                        PrescMDTs = c.Boolean(nullable: false),
                        PrescMDTsNotes = c.String(),
                        PrescNursesOffice = c.Boolean(nullable: false),
                        PrescNursesOfficeNotes = c.String(),
                        PrescOther = c.Boolean(nullable: false),
                        PrescOtherNotes = c.String(),
                        PrescUsersEpr = c.Boolean(nullable: false),
                        PrescUsersEprNotes = c.String(),
                        PrescGeneralNotes = c.String(),
                        DrugRoundBedsideRecording = c.Boolean(nullable: false),
                        DrugRoundCentralPoint = c.Boolean(nullable: false),
                        PatToCentralPoint = c.Boolean(nullable: false),
                        Other = c.Boolean(nullable: false),
                        MedAdminNotes = c.String(),
                        MedAdminUsersEpr = c.Boolean(nullable: false),
                        MedAdminUsersEprNotes = c.String(),
                        PharmCheck = c.Boolean(nullable: false),
                        PharmCheckBedsite = c.Boolean(nullable: false),
                        PharmCheckOther = c.Boolean(nullable: false),
                        PharmCheckNotes = c.String(),
                        PharmChecUsersEpr = c.Boolean(nullable: false),
                        PharmChecEprNotes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
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
                "dbo.AreaOfCares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        SiteLocationId = c.Int(),
                        Identified = c.DateTime(),
                        Identifide_notes = c.String(),
                        InformationGathering = c.DateTime(),
                        InformationGathering_notes = c.String(),
                        GoLiveDate = c.DateTime(),
                        GoLiveDate_notes = c.String(),
                        BaU = c.DateTime(),
                        BaU_notes = c.String(),
                        NotesField_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId)
                .ForeignKey("dbo.NotesFields", t => t.NotesField_Id)
                .Index(t => t.SiteLocationId)
                .Index(t => t.NotesField_Id);
            
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
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        NoteType = c.String(),
                        Note = c.String(),
                        AreaOfCareId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaOfCares", t => t.AreaOfCareId, cascadeDelete: true)
                .Index(t => t.AreaOfCareId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AreaOfCares", "NotesField_Id", "dbo.NotesFields");
            DropForeignKey("dbo.NotesFields", "AreaOfCareId", "dbo.AreaOfCares");
            DropForeignKey("dbo.AreaOfCareNews", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "HospitalSiteId", "dbo.HospitalSites");
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.NotesFields", new[] { "AreaOfCareId" });
            DropIndex("dbo.AreaOfCares", new[] { "NotesField_Id" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocationId" });
            DropIndex("dbo.SiteLocations", new[] { "HospitalSiteId" });
            DropIndex("dbo.AreaOfCareNews", new[] { "SiteLocationId" });
            DropTable("dbo.NotesFields");
            DropTable("dbo.HospitalSites");
            DropTable("dbo.AreaOfCares");
            DropTable("dbo.SiteLocations");
            DropTable("dbo.AreaOfCareNews");
        }
    }
}
