namespace FancyImageUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test_migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsBlocked", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsBlocked");
        }
    }
}
