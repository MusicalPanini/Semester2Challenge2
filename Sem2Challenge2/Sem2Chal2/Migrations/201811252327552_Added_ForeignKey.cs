namespace Sem2Chal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_ForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "Payee_Id" });
            RenameColumn(table: "dbo.Games", name: "Payee_Id", newName: "AspNetUserId");
            AlterColumn("dbo.Games", "AspNetUserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Games", "AspNetUserId");
            AddForeignKey("dbo.Games", "AspNetUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "AspNetUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "AspNetUserId" });
            AlterColumn("dbo.Games", "AspNetUserId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.Games", name: "AspNetUserId", newName: "Payee_Id");
            CreateIndex("dbo.Games", "Payee_Id");
            AddForeignKey("dbo.Games", "Payee_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
