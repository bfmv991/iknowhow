namespace SkillTradingWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        OfferID = c.Int(nullable: false, identity: true),
                        OfferName = c.String(maxLength: 255),
                        Description = c.String(maxLength: 255),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OfferID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offers", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Offers", new[] { "CategoryID" });
            DropTable("dbo.Offers");
        }
    }
}
