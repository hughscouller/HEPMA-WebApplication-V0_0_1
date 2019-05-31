namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOtherAoCClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AoCAssessments",
                c => new
                    {
                        AoCAssessmentId = c.Int(nullable: false, identity: true),
                        AoCAssessmentGoodToGo = c.Boolean(nullable: false),
                        AoCAssessmentGoodToGoDate = c.DateTime(),
                        AoCAssessmentITLiteracy = c.String(),
                        AoCAssessmentUseOfTrak = c.String(),
                        AoCAssessmentHardwareQuality = c.String(),
                        AoCAssessmentHardwareQuantity = c.String(),
                        AoCAssessmentHardwareLocation = c.String(),
                        AoCAssessmentBusinessProcessDifference = c.String(),
                        AoCAssessmentGeneralNotes = c.String(),
                        SiteLocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AoCAssessmentId)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId);
            
            CreateTable(
                "dbo.BaUChecklists",
                c => new
                    {
                        BaUChecklistId = c.Int(nullable: false, identity: true),
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
                        SiteLocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BaUChecklistId)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId);
            
            CreateTable(
                "dbo.GoliveChecklists",
                c => new
                    {
                        GoliveChecklistId = c.Int(nullable: false, identity: true),
                        GoliveChecklistUsersIdentified = c.Boolean(nullable: false),
                        GoliveChecklistUsersIdentifiedDate = c.DateTime(),
                        GoliveChecklistUsersTrained = c.Boolean(nullable: false),
                        GoliveChecklistUsersTrainedDate = c.DateTime(),
                        GoliveChecklistUsersSetup = c.Boolean(nullable: false),
                        GoliveChecklistUsersSetupDate = c.DateTime(),
                        GoliveChecklistIdentified = c.Boolean(nullable: false),
                        GoliveChecklistIdentifiedDate = c.DateTime(),
                        GoliveChecklistAgreedUse = c.Boolean(nullable: false),
                        GoliveChecklistAgreedUseDate = c.DateTime(),
                        GoliveChecklistSetupCurrent = c.Boolean(nullable: false),
                        GoliveChecklistSetupCurrentDate = c.DateTime(),
                        GoliveChecklistSetupNew = c.Boolean(nullable: false),
                        GoliveChecklistSetupNewDate = c.DateTime(),
                        GoliveChecklistPrescribing = c.Boolean(nullable: false),
                        GoliveChecklistPrescribingDate = c.DateTime(),
                        GoliveChecklistMedAdmin = c.Boolean(nullable: false),
                        GoliveChecklistMedAdminDate = c.DateTime(nullable: false),
                        GoliveChecklistPharmCheck = c.Boolean(nullable: false),
                        GoliveChecklistPharmCheckDate = c.DateTime(nullable: false),
                        GoliveChecklistContingencyAgreed = c.Boolean(nullable: false),
                        GoliveChecklistContingencyAgreedDate = c.DateTime(),
                        GoliveChecklistGo_Nogo = c.Boolean(nullable: false),
                        GoliveChecklistGo_NogoDate = c.DateTime(),
                        GoliveChecklistGeneralNotes = c.String(),
                        SiteLocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GoliveChecklistId)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId);
            
            AddColumn("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId", c => c.Int());
            AddColumn("dbo.SiteLocations", "BaUChecklist_BaUChecklistId", c => c.Int());
            AddColumn("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId", c => c.Int());
            CreateIndex("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId");
            CreateIndex("dbo.SiteLocations", "BaUChecklist_BaUChecklistId");
            CreateIndex("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId");
            AddForeignKey("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId", "dbo.AoCAssessments", "AoCAssessmentId");
            AddForeignKey("dbo.SiteLocations", "BaUChecklist_BaUChecklistId", "dbo.BaUChecklists", "BaUChecklistId");
            AddForeignKey("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId", "dbo.GoliveChecklists", "GoliveChecklistId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId", "dbo.GoliveChecklists");
            DropForeignKey("dbo.GoliveChecklists", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "BaUChecklist_BaUChecklistId", "dbo.BaUChecklists");
            DropForeignKey("dbo.BaUChecklists", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId", "dbo.AoCAssessments");
            DropForeignKey("dbo.AoCAssessments", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.GoliveChecklists", new[] { "SiteLocationId" });
            DropIndex("dbo.BaUChecklists", new[] { "SiteLocationId" });
            DropIndex("dbo.SiteLocations", new[] { "GoliveChecklist_GoliveChecklistId" });
            DropIndex("dbo.SiteLocations", new[] { "BaUChecklist_BaUChecklistId" });
            DropIndex("dbo.SiteLocations", new[] { "AoCAssessment_AoCAssessmentId" });
            DropIndex("dbo.AoCAssessments", new[] { "SiteLocationId" });
            DropColumn("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId");
            DropColumn("dbo.SiteLocations", "BaUChecklist_BaUChecklistId");
            DropColumn("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId");
            DropTable("dbo.GoliveChecklists");
            DropTable("dbo.BaUChecklists");
            DropTable("dbo.AoCAssessments");
        }
    }
}
