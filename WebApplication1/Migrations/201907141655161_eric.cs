namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eric : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotesFieldLocationOfInterests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        LoIId = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LocationOfInterests", t => t.LoIId, cascadeDelete: true)
                .Index(t => t.LoIId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldLocationOfInterests", "LoIId", "dbo.LocationOfInterests");
            DropIndex("dbo.NotesFieldLocationOfInterests", new[] { "LoIId" });
            DropTable("dbo.NotesFieldLocationOfInterests");
        }
    }
}
