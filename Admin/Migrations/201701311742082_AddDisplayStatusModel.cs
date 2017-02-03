namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDisplayStatusModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DisplayStatus",
                c => new
                    {
                        DisplayId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.DisplayId);

            Sql("INSERT INTO DisplayStatus (Status) VALUES('Enable')");
            Sql("INSERT INTO DisplayStatus (Status) VALUES('Disable')");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DisplayStatus");
        }
    }
}
