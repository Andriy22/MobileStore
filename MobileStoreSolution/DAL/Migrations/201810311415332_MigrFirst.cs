namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Phone_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Phones", t => t.Phone_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Phone_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Orders", "Phone_ID", "dbo.Phones");
            DropIndex("dbo.Orders", new[] { "User_ID" });
            DropIndex("dbo.Orders", new[] { "Phone_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Phones");
            DropTable("dbo.Orders");
        }
    }
}
