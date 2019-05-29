namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HospitalSites", "FirstContact", c => c.DateTime());
            AlterColumn("dbo.HospitalSites", "Complete", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HospitalSites", "Complete", c => c.DateTime(nullable: false));
            AlterColumn("dbo.HospitalSites", "FirstContact", c => c.DateTime(nullable: false));
        }
    }
}
