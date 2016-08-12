namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtypr213 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FileUploadDBModels", newName: "TutoPictures");
            DropColumn("dbo.TutoPictures", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TutoPictures", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            RenameTable(name: "dbo.TutoPictures", newName: "FileUploadDBModels");
        }
    }
}
