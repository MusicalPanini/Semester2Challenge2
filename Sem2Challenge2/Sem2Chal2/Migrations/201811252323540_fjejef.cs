namespace Sem2Chal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fjejef : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "Payee_Id" });
            AlterColumn("dbo.Games", "Fee", c => c.Double());
            AlterColumn("dbo.Games", "Payee_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Games", "Payee_Id");
            AddForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "Payee_Id" });
            AlterColumn("dbo.Games", "Payee_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Games", "Fee", c => c.Double(nullable: false));
            CreateIndex("dbo.Games", "Payee_Id");
            AddForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
