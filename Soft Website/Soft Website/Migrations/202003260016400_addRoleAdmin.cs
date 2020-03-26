namespace Soft_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRoleAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false),
                        image = c.String(nullable: false),
                        details = c.String(nullable: false),
                        features = c.String(nullable: false),
                        technologies = c.String(nullable: false),
                        projectUrl = c.String(),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Works", "category_Id", "dbo.Categories");
            DropIndex("dbo.Works", new[] { "category_Id" });
            DropTable("dbo.Works");
            DropTable("dbo.Categories");
        }
    }
}
