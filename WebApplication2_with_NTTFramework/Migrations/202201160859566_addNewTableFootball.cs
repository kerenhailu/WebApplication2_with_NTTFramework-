namespace WebApplication2_with_NTTFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewTableFootball : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footballs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LName = c.String(nullable: false, maxLength: 15),
                        Position = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Footballs");
        }
    }
}
