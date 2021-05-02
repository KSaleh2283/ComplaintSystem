namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstM13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Complaints", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Complaints", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Complaints", "Description", c => c.String());
            AlterColumn("dbo.Complaints", "Title", c => c.String(maxLength: 50));
        }
    }
}
