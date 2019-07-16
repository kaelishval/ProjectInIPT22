namespace ipt2project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddatefororder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Date_ordered", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Date_ordered");
        }
    }
}
