namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creaete : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotesFieldAreaOfCares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        AoCId = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaOfCares", t => t.AoCId, cascadeDelete: true)
                .Index(t => t.AoCId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldAreaOfCares", "AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.NotesFieldAreaOfCares", new[] { "AoCId" });
            DropTable("dbo.NotesFieldAreaOfCares");
        }
    }
}
