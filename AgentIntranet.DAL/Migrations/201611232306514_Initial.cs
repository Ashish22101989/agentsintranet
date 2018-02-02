namespace AgentIntranet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        AgentId = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(maxLength: 255),
                        Position = c.String(maxLength: 20),
                        Status = c.Boolean(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(maxLength: 25),
                        Email = c.String(maxLength: 25),
                        Phone = c.String(maxLength: 25),
                        Fax = c.String(maxLength: 25),
                        Street = c.String(maxLength: 50),
                        City = c.String(maxLength: 25),
                        State = c.String(maxLength: 2),
                        Zip = c.String(maxLength: 15),
                        Location_LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.AgentId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.Location_LocationId)
                .Index(t => t.CustomerId)
                .Index(t => t.Location_LocationId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        PersonId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(maxLength: 25),
                        Email = c.String(maxLength: 25),
                        Phone = c.String(maxLength: 25),
                        Fax = c.String(maxLength: 25),
                        Street = c.String(maxLength: 50),
                        City = c.String(maxLength: 25),
                        State = c.String(maxLength: 2),
                        Zip = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CreditCardId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        Number = c.String(nullable: false, maxLength: 20),
                        Code = c.String(nullable: false, maxLength: 4),
                        Valid = c.DateTime(nullable: false),
                        Type = c.String(nullable: false, maxLength: 25),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CreditCardId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Data = c.String(),
                        PostDate = c.String(),
                        LastUpdated = c.String(),
                        Status = c.Boolean(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PageId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Locations", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Agents", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.CreditCards", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Agents", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Pages", new[] { "CustomerId" });
            DropIndex("dbo.Locations", new[] { "CustomerId" });
            DropIndex("dbo.CreditCards", new[] { "CustomerId" });
            DropIndex("dbo.Agents", new[] { "Location_LocationId" });
            DropIndex("dbo.Agents", new[] { "CustomerId" });
            DropTable("dbo.Pages");
            DropTable("dbo.Locations");
            DropTable("dbo.CreditCards");
            DropTable("dbo.Customers");
            DropTable("dbo.Agents");
        }
    }
}
