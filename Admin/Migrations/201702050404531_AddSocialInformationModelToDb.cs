namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSocialInformationModelToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialInformations",
                c => new
                    {
                        SocialId = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        StoreName = c.String(),
                        StoreTagLine = c.String(),
                        StoreMobileNumber = c.String(),
                        StoreEmail = c.String(),
                        StoreAddressLine1 = c.String(),
                        StoreAddressLine2 = c.String(),
                        StoreCity = c.String(),
                        StoreState = c.String(),
                        StoreCountry = c.String(),
                        StorePostalCode = c.Int(nullable: false),
                        StoreFacebookLink = c.String(),
                        StoreTwitterLink = c.String(),
                        StoreInstagramLink = c.String(),
                        Newsletter = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SocialId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialInformations", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.SocialInformations", new[] { "User_Id" });
            DropTable("dbo.SocialInformations");
        }
    }
}
