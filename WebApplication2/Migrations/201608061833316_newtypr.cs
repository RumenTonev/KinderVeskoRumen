namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtypr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FileUploadDBModels", "TutoNumber", c => c.String());
            AddColumn("dbo.FileUploadDBModels", "Section", c => c.String());
            AddColumn("dbo.FileUploadDBModels", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FileUploadDBModels", "Discriminator");
            DropColumn("dbo.FileUploadDBModels", "Section");
            DropColumn("dbo.FileUploadDBModels", "TutoNumber");
        }
    }
}
