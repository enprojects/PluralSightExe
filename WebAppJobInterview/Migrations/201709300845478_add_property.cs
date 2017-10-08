namespace WebAppJobInterview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_property : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "MyProperty");
        }
    }
}
