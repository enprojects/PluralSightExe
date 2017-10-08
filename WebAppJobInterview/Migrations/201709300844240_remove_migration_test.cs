namespace WebAppJobInterview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_migration_test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "MigrationTest");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "MigrationTest", c => c.String());
        }
    }
}
