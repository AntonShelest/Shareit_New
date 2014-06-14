namespace FancyImageUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class file_model_added_sizeChar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "FileHeight", c => c.Int(nullable: false));
            AddColumn("dbo.Files", "FileWidth", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "FileWidth");
            DropColumn("dbo.Files", "FileHeight");
        }
    }
}
