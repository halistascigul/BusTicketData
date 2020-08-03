namespace TicketData.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusModel = c.String(maxLength: 50),
                        SeatingCapacity = c.Byte(nullable: false),
                        BusType = c.String(maxLength: 10),
                        TravelDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TravelTime = c.String(maxLength: 5),
                        WhereFrom = c.String(maxLength: 50),
                        WhereTo = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Updated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50),
                        IdentityNumber = c.Long(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(),
                        SeatNumber = c.Byte(nullable: false),
                        FeeToPay = c.Decimal(nullable: false, storeType: "money"),
                        BusId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Updated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.BusId)
                .Index(t => t.BusId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Province = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Updated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passengers", "BusId", "dbo.Buses");
            DropIndex("dbo.Passengers", new[] { "BusId" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Passengers");
            DropTable("dbo.Buses");
        }
    }
}
