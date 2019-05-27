namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updaet : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.NotesFieldHospitalSites", new[] { "hospitalSite_Id" });
            CreateIndex("dbo.NotesFieldHospitalSites", "HospitalSite_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.NotesFieldHospitalSites", new[] { "HospitalSite_Id" });
            CreateIndex("dbo.NotesFieldHospitalSites", "hospitalSite_Id");
        }
    }
}
