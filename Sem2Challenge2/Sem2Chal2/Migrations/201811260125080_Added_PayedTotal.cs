namespace Sem2Chal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_PayedTotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "TotalAmountPayed", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "TotalAmountPayed");
        }
    }
}
