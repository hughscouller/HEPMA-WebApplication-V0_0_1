namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.NotesFieldHospitalSites");
            DropTable("dbo.NotesFieldSiteLocations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NotesFieldSiteLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(),
                        CreatedBy = c.String(),
                        NoteType = c.String(),
                        Note = c.String(),
                        SiteLocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotesFieldHospitalSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(),
                        CreatedBy = c.String(),
                        NoteType = c.String(),
                        Note = c.String(),
                        HospitalSiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
