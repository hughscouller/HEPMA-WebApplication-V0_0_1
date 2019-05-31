namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AoCAssessments", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId", "dbo.AoCAssessments");
            DropForeignKey("dbo.BaUChecklists", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "BaUChecklist_BaUChecklistId", "dbo.BaUChecklists");
            DropForeignKey("dbo.GoliveChecklists", "SiteLocationId", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId", "dbo.GoliveChecklists");
            DropIndex("dbo.AoCAssessments", new[] { "SiteLocationId" });
            DropIndex("dbo.SiteLocations", new[] { "AoCAssessment_AoCAssessmentId" });
            DropIndex("dbo.SiteLocations", new[] { "BaUChecklist_BaUChecklistId" });
            DropIndex("dbo.SiteLocations", new[] { "GoliveChecklist_GoliveChecklistId" });
            DropIndex("dbo.BaUChecklists", new[] { "SiteLocationId" });
            DropIndex("dbo.GoliveChecklists", new[] { "SiteLocationId" });
            AddColumn("dbo.AreaOfCares", "AoCAssessmentGoodToGo", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "AoCAssessmentGoodToGoDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentITLiteracy", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentUseOfTrak", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentHardwareQuality", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentHardwareQuantity", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentHardwareLocation", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentBusinessProcessDifference", c => c.String());
            AddColumn("dbo.AreaOfCares", "AoCAssessmentGeneralNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistUsersIdentified", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistUsersIdentifiedDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistUsersTrained", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistUsersTrainedDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistUsersSetup", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistUsersSetupDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistIdentified", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistIdentifiedDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistAgreedUse", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistAgreedUseDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistSetupCurrent", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistSetupCurrentDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistSetupNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistSetupNewDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistPrescribing", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistPrescribingDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistMedAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistMedAdminDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistPharmCheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistPharmCheckDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistContingencyAgreed", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistContingencyAgreedDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistGo_Nogo", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistGo_NogoDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistGeneralNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaUChecklistSuccessfulGoLive", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "BaUChecklistSuccessfulGoliveNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaUChecklistTrainingComplete", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "BaUChecklistTrainingCompleteNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaUChecklistUserSetup", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "BaUChecklisUserSetupNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaUChecklistHardwareSetup", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "BaUChecklistHardwareSetupNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaUChecklistHardwareUseAgreed", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "BaUChecklistHardwareUseAgreedNotes", c => c.String());
            AddColumn("dbo.AreaOfCares", "BaUChecklistContingencyAgreed", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "BaUChecklistContingencyAgreedNotes", c => c.String());
            DropColumn("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId");
            DropColumn("dbo.SiteLocations", "BaUChecklist_BaUChecklistId");
            DropColumn("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId");
            DropTable("dbo.AoCAssessments");
            DropTable("dbo.BaUChecklists");
            DropTable("dbo.GoliveChecklists");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.GoliveChecklistId);
            
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
                .PrimaryKey(t => t.BaUChecklistId);
            
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
                .PrimaryKey(t => t.AoCAssessmentId);
            
            AddColumn("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId", c => c.Int());
            AddColumn("dbo.SiteLocations", "BaUChecklist_BaUChecklistId", c => c.Int());
            AddColumn("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId", c => c.Int());
            DropColumn("dbo.AreaOfCares", "BaUChecklistContingencyAgreedNotes");
            DropColumn("dbo.AreaOfCares", "BaUChecklistContingencyAgreed");
            DropColumn("dbo.AreaOfCares", "BaUChecklistHardwareUseAgreedNotes");
            DropColumn("dbo.AreaOfCares", "BaUChecklistHardwareUseAgreed");
            DropColumn("dbo.AreaOfCares", "BaUChecklistHardwareSetupNotes");
            DropColumn("dbo.AreaOfCares", "BaUChecklistHardwareSetup");
            DropColumn("dbo.AreaOfCares", "BaUChecklisUserSetupNotes");
            DropColumn("dbo.AreaOfCares", "BaUChecklistUserSetup");
            DropColumn("dbo.AreaOfCares", "BaUChecklistTrainingCompleteNotes");
            DropColumn("dbo.AreaOfCares", "BaUChecklistTrainingComplete");
            DropColumn("dbo.AreaOfCares", "BaUChecklistSuccessfulGoliveNotes");
            DropColumn("dbo.AreaOfCares", "BaUChecklistSuccessfulGoLive");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistGeneralNotes");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistGo_NogoDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistGo_Nogo");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistContingencyAgreedDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistContingencyAgreed");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistPharmCheckDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistPharmCheck");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistMedAdminDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistMedAdmin");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistPrescribingDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistPrescribing");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistSetupNewDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistSetupNew");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistSetupCurrentDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistSetupCurrent");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistAgreedUseDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistAgreedUse");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistIdentifiedDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistIdentified");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistUsersSetupDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistUsersSetup");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistUsersTrainedDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistUsersTrained");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistUsersIdentifiedDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistUsersIdentified");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentGeneralNotes");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentBusinessProcessDifference");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentHardwareLocation");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentHardwareQuantity");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentHardwareQuality");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentUseOfTrak");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentITLiteracy");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentGoodToGoDate");
            DropColumn("dbo.AreaOfCares", "AoCAssessmentGoodToGo");
            CreateIndex("dbo.GoliveChecklists", "SiteLocationId");
            CreateIndex("dbo.BaUChecklists", "SiteLocationId");
            CreateIndex("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId");
            CreateIndex("dbo.SiteLocations", "BaUChecklist_BaUChecklistId");
            CreateIndex("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId");
            CreateIndex("dbo.AoCAssessments", "SiteLocationId");
            AddForeignKey("dbo.SiteLocations", "GoliveChecklist_GoliveChecklistId", "dbo.GoliveChecklists", "GoliveChecklistId");
            AddForeignKey("dbo.GoliveChecklists", "SiteLocationId", "dbo.SiteLocations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SiteLocations", "BaUChecklist_BaUChecklistId", "dbo.BaUChecklists", "BaUChecklistId");
            AddForeignKey("dbo.BaUChecklists", "SiteLocationId", "dbo.SiteLocations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SiteLocations", "AoCAssessment_AoCAssessmentId", "dbo.AoCAssessments", "AoCAssessmentId");
            AddForeignKey("dbo.AoCAssessments", "SiteLocationId", "dbo.SiteLocations", "Id", cascadeDelete: true);
        }
    }
}
