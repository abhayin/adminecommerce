namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ShippingFirstName = c.String(),
                        ShippingLastName = c.String(),
                        ShippingAddressLine1 = c.String(),
                        ShippingAddressLine2 = c.String(),
                        ShippingCity = c.String(),
                        ShippingState = c.String(),
                        ShippingCountry = c.String(),
                        ShippingPostalCode = c.Int(nullable: false),
                        BillingFirstName = c.String(),
                        BillingLastName = c.String(),
                        BillingAddressLine1 = c.String(),
                        BillingAddressLine2 = c.String(),
                        BillingCity = c.String(),
                        BillingState = c.String(),
                        BillingCountry = c.String(),
                        BillingPostalCode = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropTable("dbo.Addresses");
        }
    }
}
