namespace EfMigrationsBug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePkType : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Foos");
            CreateTable(
                "dbo.Foos",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
            DropTable("dbo.Foos");
            CreateTable(
                "dbo.Foos",
                c => new
                {
                    ID = c.String(nullable: false, maxLength: 5),
                })
                .PrimaryKey(t => t.ID);
        }
    }
}
