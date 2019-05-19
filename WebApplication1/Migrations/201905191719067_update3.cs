namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AreaOfCares", "AoCFirstContactDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AreaOfCares", "AoCFirstContactDate", c => c.DateTime(nullable: false));
        }
    }
}
