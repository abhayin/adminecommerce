namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTheDatatypeOfUserId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropColumn("dbo.Addresses", "UserId");
            RenameColumn(table: "dbo.Addresses", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Addresses", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Addresses", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Addresses", new[] { "UserId" });
            AlterColumn("dbo.Addresses", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Addresses", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Addresses", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "User_Id");
        }
    }
}
