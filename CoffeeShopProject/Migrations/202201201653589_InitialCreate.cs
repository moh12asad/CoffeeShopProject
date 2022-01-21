namespace CoffeeShopProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        alcohol = c.String(nullable: false),
                        ptime = c.String(nullable: false),
                        numordered = c.Int(nullable: false),
                        saleprice = c.String(nullable: false),
                        price = c.String(nullable: false),
                        sale = c.String(nullable: false),


                    })
                .PrimaryKey(t => t.name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
