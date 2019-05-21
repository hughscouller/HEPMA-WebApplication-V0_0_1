namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data03 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations");
            AddColumn("dbo.AreaOfCares", "SiteLocation_Id", c => c.Int());
            AddColumn("dbo.SiteLocations", "AreaOfCare_AoCId", c => c.Int());
            CreateIndex("dbo.AreaOfCares", "SiteLocation_Id");
            CreateIndex("dbo.SiteLocations", "AreaOfCare_AoCId");
            AddForeignKey("dbo.SiteLocations", "AreaOfCare_AoCId", "dbo.AreaOfCares", "AoCId");
            AddForeignKey("dbo.AreaOfCares", "SiteLocation_Id", "dbo.SiteLocations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AreaOfCares", "SiteLocation_Id", "dbo.SiteLocations");
            DropForeignKey("dbo.SiteLocations", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.SiteLocations", new[] { "AreaOfCare_AoCId" });
            DropIndex("dbo.AreaOfCares", new[] { "SiteLocation_Id" });
            DropColumn("dbo.SiteLocations", "AreaOfCare_AoCId");
            DropColumn("dbo.AreaOfCares", "SiteLocation_Id");
            AddForeignKey("dbo.AreaOfCares", "SiteLocationId", "dbo.SiteLocations", "Id", cascadeDelete: true);
        }
    }
}
