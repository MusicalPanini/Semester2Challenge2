namespace Sem2Challenge2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Game : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameModels",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        WhosPaying = c.String(nullable: false),
                        Venue = c.String(nullable: false),
                        FeeAmount = c.Double(nullable: false),
                        GameDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GameModels");
        }
    }
}
