namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AreaOfCares", "GoliveChecklistMedAdminDate", c => c.DateTime());
            AlterColumn("dbo.AreaOfCares", "GoliveChecklistPharmCheckDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AreaOfCares", "GoliveChecklistPharmCheckDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AreaOfCares", "GoliveChecklistMedAdminDate", c => c.DateTime(nullable: false));
        }
    }
}
