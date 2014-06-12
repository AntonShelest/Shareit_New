namespace FancyImageUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class file_model_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileData = c.Binary(),
                        FileSmallData = c.Binary(),
                        FolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Files");
        }
    }
}
