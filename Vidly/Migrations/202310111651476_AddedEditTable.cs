namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEditTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreSections",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Movies", "GenreSectionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Movies", "GenreSectionId");
            AddForeignKey("dbo.Movies", "GenreSectionId", "dbo.GenreSections", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreSectionId", "dbo.GenreSections");
            DropIndex("dbo.Movies", new[] { "GenreSectionId" });
            AlterColumn("dbo.Genres", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "GenreSectionId");
            DropTable("dbo.GenreSections");
        }
    }
}
