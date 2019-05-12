namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactor01 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocationId" });
            AddColumn("dbo.AreaOfCares", "AocType", c => c.String());
            AddColumn("dbo.AreaOfCares", "Status", c => c.String());
            AddColumn("dbo.AreaOfCares", "FirstContactDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "FirstContactNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PlannedGoLiveDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "PlannedGoLiveNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "ActualGoLiveDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "ActualGoLiveNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BauHandoverDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "BauHandoverNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCGeneralNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "ADTs", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "ADTsRealTime", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "ADTsNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "OPCLinic", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "OPClinicRealTIme", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "OPClinicNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "MedRec", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "MedRecWho", c => c.String());
            AddColumn("dbo.AreaOfCares", "MedRecWhere", c => c.String());
            AddColumn("dbo.AreaOfCares", "MedRecWhen", c => c.String());
            AddColumn("dbo.AreaOfCares", "MedRecNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PrescWardRounds", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PrescWardRoundsNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PrescMDTs", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PrescMDTsNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PrescNursesOffice", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PrescNursesOfficeNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PrescOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PrescOtherNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PrescUsersEpr", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PrescUsersEprNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PrescGeneralNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "DrugRoundBedsideRecording", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "DrugRoundCentralPoint", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PatToCentralPoint", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "Other", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "MedAdminNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "MedAdminUsersEpr", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "MedAdminUsersEprNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PharmCheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PharmCheckBedsite", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PharmCheckOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PharmCheckNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "PharmChecUsersEpr", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "PharmChecEprNotes", c => c.String());
            AlterColumn("dbo.AreaOfCares", "SiteLocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.AreaOfCares", "SiteLocationId");
            AddForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations", "Id", cascadeDelete: true);
            DropColumn("dbo.AreaOfCares", "Identified");
            DropColumn("dbo.AreaOfCares", "Identifide_notes");
            DropColumn("dbo.AreaOfCares", "InformationGathering");
            DropColumn("dbo.AreaOfCares", "InformationGathering_notes");
            DropColumn("dbo.AreaOfCares", "GoLiveDate");
            DropColumn("dbo.AreaOfCares", "GoLiveDate_notes");
            DropColumn("dbo.AreaOfCares", "BaU");
            DropColumn("dbo.AreaOfCares", "BaU_notes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AreaOfCares", "BaU_notes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaU", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoLiveDate_notes", c => c.String());
            AddColumn("dbo.AreaOfCares", "GoLiveDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "InformationGathering_notes", c => c.String());
            AddColumn("dbo.AreaOfCares", "InformationGathering", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "Identifide_notes", c => c.String());
            AddColumn("dbo.AreaOfCares", "Identified", c => c.DateTime());
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocationId" });
            AlterColumn("dbo.AreaOfCares", "SiteLocationId", c => c.Int());
            DropColumn("dbo.AreaOfCares", "PharmChecEprNotes");
            DropColumn("dbo.AreaOfCares", "PharmChecUsersEpr");
            DropColumn("dbo.AreaOfCares", "PharmCheckNotes");
            DropColumn("dbo.AreaOfCares", "PharmCheckOther");
            DropColumn("dbo.AreaOfCares", "PharmCheckBedsite");
            DropColumn("dbo.AreaOfCares", "PharmCheck");
            DropColumn("dbo.AreaOfCares", "MedAdminUsersEprNotes");
            DropColumn("dbo.AreaOfCares", "MedAdminUsersEpr");
            DropColumn("dbo.AreaOfCares", "MedAdminNotes");
            DropColumn("dbo.AreaOfCares", "Other");
            DropColumn("dbo.AreaOfCares", "PatToCentralPoint");
            DropColumn("dbo.AreaOfCares", "DrugRoundCentralPoint");
            DropColumn("dbo.AreaOfCares", "DrugRoundBedsideRecording");
            DropColumn("dbo.AreaOfCares", "PrescGeneralNotes");
            DropColumn("dbo.AreaOfCares", "PrescUsersEprNotes");
            DropColumn("dbo.AreaOfCares", "PrescUsersEpr");
            DropColumn("dbo.AreaOfCares", "PrescOtherNotes");
            DropColumn("dbo.AreaOfCares", "PrescOther");
            DropColumn("dbo.AreaOfCares", "PrescNursesOfficeNotes");
            DropColumn("dbo.AreaOfCares", "PrescNursesOffice");
            DropColumn("dbo.AreaOfCares", "PrescMDTsNotes");
            DropColumn("dbo.AreaOfCares", "PrescMDTs");
            DropColumn("dbo.AreaOfCares", "PrescWardRoundsNotes");
            DropColumn("dbo.AreaOfCares", "PrescWardRounds");
            DropColumn("dbo.AreaOfCares", "MedRecNotes");
            DropColumn("dbo.AreaOfCares", "MedRecWhen");
            DropColumn("dbo.AreaOfCares", "MedRecWhere");
            DropColumn("dbo.AreaOfCares", "MedRecWho");
            DropColumn("dbo.AreaOfCares", "MedRec");
            DropColumn("dbo.AreaOfCares", "OPClinicNotes");
            DropColumn("dbo.AreaOfCares", "OPClinicRealTIme");
            DropColumn("dbo.AreaOfCares", "OPCLinic");
            DropColumn("dbo.AreaOfCares", "ADTsNotes");
            DropColumn("dbo.AreaOfCares", "ADTsRealTime");
            DropColumn("dbo.AreaOfCares", "ADTs");
            DropColumn("dbo.AreaOfCares", "AoCGeneralNotes");
            DropColumn("dbo.AreaOfCares", "BauHandoverNotes");
            DropColumn("dbo.AreaOfCares", "BauHandoverDate");
            DropColumn("dbo.AreaOfCares", "ActualGoLiveNotes");
            DropColumn("dbo.AreaOfCares", "ActualGoLiveDate");
            DropColumn("dbo.AreaOfCares", "PlannedGoLiveNotes");
            DropColumn("dbo.AreaOfCares", "PlannedGoLiveDate");
            DropColumn("dbo.AreaOfCares", "FirstContactNotes");
            DropColumn("dbo.AreaOfCares", "FirstContactDate");
            DropColumn("dbo.AreaOfCares", "Status");
            DropColumn("dbo.AreaOfCares", "AocType");
            CreateIndex("dbo.AreaOfCares", "SiteLocationId");
            AddForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations", "Id");
        }
    }
}
