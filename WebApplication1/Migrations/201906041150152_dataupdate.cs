namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AreaOfCares", "GoliveChecklistIdentified");
            DropColumn("dbo.AreaOfCares", "GoliveChecklistIdentifiedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AreaOfCares", "GoliveChecklistIdentifiedDate", c => c.DateTime());
            AddColumn("dbo.AreaOfCares", "GoliveChecklistIdentified", c => c.Boolean(nullable: false));
        }
    }
}
