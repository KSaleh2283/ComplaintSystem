namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstM12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "UserName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Profiles", "Password", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "Password", c => c.String(maxLength: 50));
            AlterColumn("dbo.Profiles", "UserName", c => c.String(maxLength: 50));
        }
    }
}
