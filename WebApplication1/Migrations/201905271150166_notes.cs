namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotesFieldHospitalSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        NoteType = c.String(),
                        HospitalId = c.Int(nullable: false),
                        Note = c.String(),
                        hospitalSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HospitalSites", t => t.hospitalSite_Id)
                .Index(t => t.hospitalSite_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldHospitalSites", "hospitalSite_Id", "dbo.HospitalSites");
            DropIndex("dbo.NotesFieldHospitalSites", new[] { "hospitalSite_Id" });
            DropTable("dbo.NotesFieldHospitalSites");
        }
    }
}
