namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AreaOfCares", "AoCAssessmentHardwareQuantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AreaOfCares", "AoCAssessmentHardwareQuantity", c => c.String());
        }
    }
}
