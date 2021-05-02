namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstM11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Profiles", "FirstName");
            DropColumn("dbo.Profiles", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "LastName", c => c.String(maxLength: 50));
            AddColumn("dbo.Profiles", "FirstName", c => c.String(maxLength: 50));
        }
    }
}
