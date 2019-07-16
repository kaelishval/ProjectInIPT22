namespace ipt2project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Histories", "Date_ordered", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Histories", "Date_order");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Histories", "Date_order", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Histories", "Date_ordered");
        }
    }
}
