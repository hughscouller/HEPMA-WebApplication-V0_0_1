namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotesFieldSiteLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        SiteLocationId = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SiteLocations", t => t.SiteLocationId, cascadeDelete: true)
                .Index(t => t.SiteLocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldSiteLocations", "SiteLocationId", "dbo.SiteLocations");
            DropIndex("dbo.NotesFieldSiteLocations", new[] { "SiteLocationId" });
            DropTable("dbo.NotesFieldSiteLocations");
        }
    }
}
