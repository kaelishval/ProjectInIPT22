namespace ipt2project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class historyStatusAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Histories", "Status", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Histories", "Status");
        }
    }
}
