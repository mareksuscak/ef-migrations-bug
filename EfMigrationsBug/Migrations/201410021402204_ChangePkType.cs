namespace EfMigrationsBug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePkType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Foos");
            AlterColumn("dbo.Foos", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Foos", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Foos");
            AlterColumn("dbo.Foos", "ID", c => c.String(nullable: false, maxLength: 5));
            AddPrimaryKey("dbo.Foos", "ID");
        }
    }
}
