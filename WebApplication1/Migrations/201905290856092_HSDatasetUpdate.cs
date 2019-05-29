namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HSDatasetUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HospitalSites", "FirstContact", c => c.DateTime(nullable: false));
            AddColumn("dbo.HospitalSites", "Complete", c => c.DateTime(nullable: false));
            AddColumn("dbo.HospitalSites", "AccommodationComplimentStandardBed", c => c.Int(nullable: false));
            AddColumn("dbo.HospitalSites", "AccommodationComplimentDaySurgeryBed", c => c.Int(nullable: false));
            AddColumn("dbo.HospitalSites", "AccommodationComplimentTrolly", c => c.Int(nullable: false));
            AddColumn("dbo.HospitalSites", "AccommodationComplimentChair", c => c.Int(nullable: false));
            AddColumn("dbo.HospitalSites", "AccommodationComplimentSpecialCareBabyUnitCot", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HospitalSites", "AccommodationComplimentSpecialCareBabyUnitCot");
            DropColumn("dbo.HospitalSites", "AccommodationComplimentChair");
            DropColumn("dbo.HospitalSites", "AccommodationComplimentTrolly");
            DropColumn("dbo.HospitalSites", "AccommodationComplimentDaySurgeryBed");
            DropColumn("dbo.HospitalSites", "AccommodationComplimentStandardBed");
            DropColumn("dbo.HospitalSites", "Complete");
            DropColumn("dbo.HospitalSites", "FirstContact");
        }
    }
}
