namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HSdataUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HospitalSites", "PlannedStart", c => c.DateTime());
            AddColumn("dbo.HospitalSites", "PlannedComplete", c => c.DateTime());
            DropColumn("dbo.HospitalSites", "FirstContact");
            DropColumn("dbo.HospitalSites", "Complete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HospitalSites", "Complete", c => c.DateTime());
            AddColumn("dbo.HospitalSites", "FirstContact", c => c.DateTime());
            DropColumn("dbo.HospitalSites", "PlannedComplete");
            DropColumn("dbo.HospitalSites", "PlannedStart");
        }
    }
}
