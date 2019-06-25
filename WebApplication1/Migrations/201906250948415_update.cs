namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hardwares", "HLoIId", c => c.Int(nullable: false));
            AddColumn("dbo.LocationOfInterests", "LoIAoCId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LocationOfInterests", "LoIAoCId");
            DropColumn("dbo.Hardwares", "HLoIId");
        }
    }
}
