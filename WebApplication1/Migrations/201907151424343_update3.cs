namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NotesFeildLocationOfInterests", newName: "LocationOfInterests");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.LocationOfInterests", newName: "NotesFeildLocationOfInterests");
        }
    }
}
