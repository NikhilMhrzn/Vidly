namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookDetails", "Id", "dbo.Books");
            DropIndex("dbo.BookDetails", new[] { "Id" });
            DropTable("dbo.Books");
            DropTable("dbo.BookDetails");
        }
    }
}
