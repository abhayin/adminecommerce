namespace Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuestoDisplayStatus : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE DisplayStatus SET Display = 1 WHERE DisplayId = 1");
            Sql("UPDATE DisplayStatus SET Display = 0 WHERE DisplayId = 2");
        }
        
        public override void Down()
        {
        }
    }
}
