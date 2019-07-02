namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AreaOfCares", "AoCFirstContact");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AreaOfCares", "AoCFirstContact", c => c.Boolean(nullable: false));
        }
    }
}
