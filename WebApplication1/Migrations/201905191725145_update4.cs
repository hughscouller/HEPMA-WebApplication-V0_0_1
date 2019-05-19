namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AreaOfCares", "AoCImplementationOrder", c => c.Int(nullable: false));
            DropColumn("dbo.AreaOfCares", "AoCAoCImplementationOrder");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AreaOfCares", "AoCAoCImplementationOrder", c => c.Int(nullable: false));
            DropColumn("dbo.AreaOfCares", "AoCImplementationOrder");
        }
    }
}
