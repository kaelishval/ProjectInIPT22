namespace ipt2project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Histories", "Date_delivered", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Histories", "Date_delivered");
        }
    }
}
