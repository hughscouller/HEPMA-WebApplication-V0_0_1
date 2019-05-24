namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AoCFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AreaOfCares", "AoCPlannedGoLiveDateAgreedAoC", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AreaOfCares", "AoCPlannedGoLiveDateAgreedAoC");
        }
    }
}
