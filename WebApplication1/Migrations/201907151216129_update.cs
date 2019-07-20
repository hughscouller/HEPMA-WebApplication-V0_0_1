namespace WebApplication1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class update : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LocationOfInterests", newName: "NotesFeildLocationOfInterests");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.NotesFeildLocationOfInterests", newName: "LocationOfInterests");
        }
    }
}
