namespace ipt2project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seanstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        product_id = c.Int(nullable: false, identity: true),
                        product_name = c.String(nullable: false, unicode: false),
                        product_type = c.String(nullable: false, unicode: false),
                        quantity = c.String(nullable: false, unicode: false),
                        price = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.product_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
