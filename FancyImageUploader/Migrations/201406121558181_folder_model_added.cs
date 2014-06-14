namespace FancyImageUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class folder_model_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Folders",
                c => new
                    {
                        FolderId = c.Int(nullable: false, identity: true),
                        FolderName = c.String(),
                        FolderUserId = c.Int(nullable: false),
                        SupFolderId = c.Int(nullable: false),
                        FolderRights = c.Int(nullable: false),
                        FolderLink = c.String(),
                    })
                .PrimaryKey(t => t.FolderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Folders");
        }
    }
}
