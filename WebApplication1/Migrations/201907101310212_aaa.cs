namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
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
                        AreaOfCareId = c.Int(nullable: false),
                        Note = c.String(),
                        areaOfCare_AoCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaOfCares", t => t.areaOfCare_AoCId)
                .Index(t => t.areaOfCare_AoCId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.NotesFieldAreaOfCares", new[] { "areaOfCare_AoCId" });
            DropTable("dbo.NotesFieldAreaOfCares");
        }
    }
}
