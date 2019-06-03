namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AreaOfCares", "GoliveChecklistIdentified", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "GoliveChecklistIdentifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AreaOfCares", "GoliveChecklistIdentifiedDate");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistIdentified");
        }
    }
}
