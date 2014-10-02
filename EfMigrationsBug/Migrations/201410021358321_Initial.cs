namespace EfMigrationsBug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foos",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Foos");
        }
    }
}
