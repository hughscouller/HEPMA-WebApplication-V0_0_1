namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactor02 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AreaOfCareNews", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.AreaOfCareNews", new[] { "SiteLocationId" });
            DropTable("dbo.AreaOfCareNews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AreaOfCareNews",
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.AreaOfCareNews", "SiteLocationId");
            AddForeignKey("dbo.AreaOfCareNews", "SiteLocationId", "dbo.SiteLocations", "Id", cascadeDelete: true);
        }
    }
}
