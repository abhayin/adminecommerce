namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeginKey : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SocialInformations", new[] { "User_Id" });
            DropColumn("dbo.SocialInformations", "UserId");
            RenameColumn(table: "dbo.SocialInformations", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.SocialInformations", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.SocialInformations", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.SocialInformations", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SocialInformations", new[] { "UserId" });
            AlterColumn("dbo.SocialInformations", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SocialInformations", "UserId", c => c.String());
            RenameColumn(table: "dbo.SocialInformations", name: "UserId", newName: "User_Id");
            AddColumn("dbo.SocialInformations", "UserId", c => c.String());
            CreateIndex("dbo.SocialInformations", "User_Id");
        }
    }
}
