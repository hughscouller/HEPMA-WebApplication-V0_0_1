namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlannedGoLiveChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AreaOfCares", "AoCPlannedGoLiveDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AreaOfCares", "AoCImplementationOrder");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AreaOfCares", "AoCImplementationOrder", c => c.Int(nullable: false));
            DropColumn("dbo.AreaOfCares", "AoCPlannedGoLiveDate");
        }
    }
}
