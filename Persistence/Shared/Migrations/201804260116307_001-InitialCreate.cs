namespace Alquiler.Persistence.Shared.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bodyparts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Serial = c.String(nullable: false, maxLength: 60),
                        CategoryId = c.Int(nullable: false),
                        Branding = c.String(nullable: false, maxLength: 60),
                        Cost = c.Decimal(nullable: false, precision: 15, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: false)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        IsBodyPart = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CityCounties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Compositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentId = c.Int(nullable: false),
                        BodyPartId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bodyparts", t => t.BodyPartId, cascadeDelete: true)
                .ForeignKey("dbo.Equipments", t => t.EquipmentId, cascadeDelete: true)
                .Index(t => t.EquipmentId)
                .Index(t => t.BodyPartId);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        LongName = c.String(nullable: false, maxLength: 60),
                        Serial = c.String(nullable: false, maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        Branding = c.String(nullable: false),
                        Seller = c.String(),
                        Buydate = c.DateTime(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 15, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 15, scale: 2),
                        RentPrice = c.Decimal(nullable: false, precision: 15, scale: 2),
                        IsCompound = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.WarehouseId);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GovermentBusinessId = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        CityCountyId = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                        PBX = c.String(nullable: false),
                        OfficePhoneAlt = c.String(),
                        MobilePhoneMain = c.String(nullable: false),
                        MobilePhoneAlt = c.String(),
                        Website = c.String(),
                        Email = c.String(nullable: false),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CityCounties", t => t.CityCountyId, cascadeDelete: true)
                .Index(t => t.CityCountyId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Address = c.String(nullable: false, maxLength: 100),
                        CityCountyId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ProjectPhoneAlt = c.String(nullable: false, maxLength: 30),
                        MobilePhoneMain = c.String(nullable: false, maxLength: 30),
                        MobilePhoneAlt = c.String(nullable: false, maxLength: 30),
                        Contact = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 120),
                        Comments = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CityCounties", t => t.CityCountyId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .Index(t => t.CityCountyId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipments", t => t.EquipmentId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: false)
                .Index(t => t.EquipmentId)
                .Index(t => t.WarehouseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Stocks", "EquipmentId", "dbo.Equipments");
            DropForeignKey("dbo.Projects", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Projects", "CityCountyId", "dbo.CityCounties");
            DropForeignKey("dbo.Customers", "CityCountyId", "dbo.CityCounties");
            DropForeignKey("dbo.Compositions", "EquipmentId", "dbo.Equipments");
            DropForeignKey("dbo.Equipments", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Equipments", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Compositions", "BodyPartId", "dbo.Bodyparts");
            DropForeignKey("dbo.Bodyparts", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "WarehouseId" });
            DropIndex("dbo.Stocks", new[] { "EquipmentId" });
            DropIndex("dbo.Projects", new[] { "CustomerId" });
            DropIndex("dbo.Projects", new[] { "CityCountyId" });
            DropIndex("dbo.Customers", new[] { "CityCountyId" });
            DropIndex("dbo.Equipments", new[] { "WarehouseId" });
            DropIndex("dbo.Equipments", new[] { "CategoryId" });
            DropIndex("dbo.Compositions", new[] { "BodyPartId" });
            DropIndex("dbo.Compositions", new[] { "EquipmentId" });
            DropIndex("dbo.Bodyparts", new[] { "CategoryId" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Projects");
            DropTable("dbo.Customers");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Equipments");
            DropTable("dbo.Compositions");
            DropTable("dbo.CityCounties");
            DropTable("dbo.Categories");
            DropTable("dbo.Bodyparts");
        }
    }
}
