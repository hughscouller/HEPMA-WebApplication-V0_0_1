namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notesupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NotesFieldHospitalSites", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NotesFieldHospitalSites", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
