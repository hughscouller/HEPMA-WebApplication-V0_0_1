namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _44 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.NotesFieldAreaOfCares", new[] { "areaOfCare_AoCId" });
            DropTable("dbo.NotesFieldAreaOfCares");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NotesFieldAreaOfCares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(),
                        NoteType = c.String(),
                        AreaOfCareId = c.Int(nullable: false),
                        Note = c.String(),
                        areaOfCare_AoCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId");
            AddForeignKey("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId", "dbo.AreaOfCares", "AoCId");
        }
    }
}
