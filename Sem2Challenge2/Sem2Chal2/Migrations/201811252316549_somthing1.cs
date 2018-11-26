namespace Sem2Chal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somthing1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Fee = c.Double(nullable: false),
                        Venue = c.String(nullable: false),
                        GameDate = c.DateTime(nullable: false),
                        Payee_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.GameID)
                .ForeignKey("dbo.AspNetUsers", t => t.Payee_Id, cascadeDelete: true)
                .Index(t => t.Payee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "Payee_Id" });
            DropTable("dbo.Games");
        }
    }
}
