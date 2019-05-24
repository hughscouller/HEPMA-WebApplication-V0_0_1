namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addScopeFieldsToAoC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AreaOfCares", "InScope", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "NoLongerInScope", c => c.Boolean(nullable: false));
            AddColumn("dbo.AreaOfCares", "NoLongerInScopeReason", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AreaOfCares", "NoLongerInScopeReason");
            DropColumn("dbo.AreaOfCares", "NoLongerInScope");
            DropColumn("dbo.AreaOfCares", "InScope");
        }
    }
}
