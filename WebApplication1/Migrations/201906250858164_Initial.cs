namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hardwares",
                c => new
                    {
                        HId = c.Int(nullable: false, identity: true),
                        HType = c.String(),
                        HAssetNumber = c.String(),
                        HMacAddress = c.String(),
                        HNetworkPort = c.String(),
                        HNPInUse = c.Boolean(nullable: false),
                        HElectricalSocket = c.String(),
                        HESInUse = c.Boolean(nullable: false),
                        HTrailingSocket = c.Boolean(nullable: false),
                        LocationOfInterest_LoIId = c.Int(),
                    })
                .PrimaryKey(t => t.HId)
                .ForeignKey("dbo.LocationOfInterests", t => t.LocationOfInterest_LoIId)
                .Index(t => t.LocationOfInterest_LoIId);
            
            CreateTable(
                "dbo.LocationOfInterests",
                c => new
                    {
                        LoIId = c.Int(nullable: false, identity: true),
                        LoIName = c.String(),
                        LoIRoomReference = c.String(),
                        LoIDescription = c.String(),
                        LoIPrescribing = c.Boolean(nullable: false),
                        LoIMedicinesAdministration = c.Boolean(nullable: false),
                        LoIPharmacyCheck = c.Boolean(nullable: false),
                        LoINotes = c.String(),
                        AreaOfCare_AoCId = c.Int(),
                    })
                .PrimaryKey(t => t.LoIId)
                .ForeignKey("dbo.AreaOfCares", t => t.AreaOfCare_AoCId)
                .Index(t => t.AreaOfCare_AoCId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hardwares", "LocationOfInterest_LoIId", "dbo.LocationOfInterests");
            DropForeignKey("dbo.LocationOfInterests", "AreaOfCare_AoCId", "dbo.AreaOfCares");
            DropIndex("dbo.LocationOfInterests", new[] { "AreaOfCare_AoCId" });
            DropIndex("dbo.Hardwares", new[] { "LocationOfInterest_LoIId" });
            DropTable("dbo.LocationOfInterests");
            DropTable("dbo.Hardwares");
        }
    }
}
