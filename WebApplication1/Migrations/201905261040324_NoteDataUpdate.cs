namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoteDataUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NotesFields", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.NotesFields", new[] { "AreaOfCare_AoCId" });
            AddColumn("dbo.NotesFields", "NoteContext", c => c.String());
            AddColumn("dbo.NotesFields", "NoteContextIdId", c => c.Int(nullable: false));
            DropColumn("dbo.NotesFields", "AreaOfCareId");
            DropColumn("dbo.NotesFields", "AreaOfCare_AoCId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotesFields", "AreaOfCare_AoCId", c => c.Int());
            AddColumn("dbo.NotesFields", "AreaOfCareId", c => c.Int(nullable: false));
            DropColumn("dbo.NotesFields", "NoteContextIdId");
            DropColumn("dbo.NotesFields", "NoteContext");
            CreateIndex("dbo.NotesFields", "AreaOfCare_AoCId");
            AddForeignKey("dbo.NotesFields", "AreaOfCare_AoCId", "dbo.AreaOfCares", "AoCId");
        }
    }
}
