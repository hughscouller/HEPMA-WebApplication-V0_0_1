namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _66 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.NotesFieldAreaOfCares", new[] { "areaOfCare_AoCId" });
            RenameColumn(table: "dbo.NotesFieldAreaOfCares", name: "areaOfCare_AoCId", newName: "AoCId");
            AlterColumn("dbo.NotesFieldAreaOfCares", "AoCId", c => c.Int(nullable: false));
            CreateIndex("dbo.NotesFieldAreaOfCares", "AoCId");
            AddForeignKey("dbo.NotesFieldAreaOfCares", "AoCId", "dbo.AreaOfCares", "AoCId", cascadeDelete: true);
            DropColumn("dbo.NotesFieldAreaOfCares", "HospitalId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotesFieldAreaOfCares", "HospitalId", c => c.Int(nullable: false));
            DropForeignKey("dbo.NotesFieldAreaOfCares", "AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.NotesFieldAreaOfCares", new[] { "AoCId" });
            AlterColumn("dbo.NotesFieldAreaOfCares", "AoCId", c => c.Int());
            RenameColumn(table: "dbo.NotesFieldAreaOfCares", name: "AoCId", newName: "areaOfCare_AoCId");
            CreateIndex("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId");
            AddForeignKey("dbo.NotesFieldAreaOfCares", "areaOfCare_AoCId", "dbo.AreaOfCares", "AoCId");
        }
    }
}
