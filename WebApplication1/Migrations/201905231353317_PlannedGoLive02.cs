namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlannedGoLive02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AreaOfCares", "AoCPlannedGoLiveDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AreaOfCares", "AoCPlannedGoLiveDate", c => c.DateTime(nullable: false));
        }
    }
}
