namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complaints",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Description = c.String(),
                        ComplaintTypeID = c.Int(nullable: false),
                        ComplaintStatusID = c.Int(nullable: false),
                        ProfileID = c.Int(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ComplaintStatus", t => t.ComplaintStatusID, cascadeDelete: true)
                .ForeignKey("dbo.ComplaintTypes", t => t.ComplaintTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Profiles", t => t.ProfileID, cascadeDelete: true)
                .Index(t => t.ComplaintTypeID)
                .Index(t => t.ComplaintStatusID)
                .Index(t => t.ProfileID);
            
            CreateTable(
                "dbo.ComplaintStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ComplaintTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        ProfileTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProfileTypes", t => t.ProfileTypeID, cascadeDelete: true)
                .Index(t => t.ProfileTypeID);
            
            CreateTable(
                "dbo.ProfileTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Complaints", "ProfileID", "dbo.Profiles");
            DropForeignKey("dbo.Profiles", "ProfileTypeID", "dbo.ProfileTypes");
            DropForeignKey("dbo.Complaints", "ComplaintTypeID", "dbo.ComplaintTypes");
            DropForeignKey("dbo.Complaints", "ComplaintStatusID", "dbo.ComplaintStatus");
            DropIndex("dbo.Profiles", new[] { "ProfileTypeID" });
            DropIndex("dbo.Complaints", new[] { "ProfileID" });
            DropIndex("dbo.Complaints", new[] { "ComplaintStatusID" });
            DropIndex("dbo.Complaints", new[] { "ComplaintTypeID" });
            DropTable("dbo.ProfileTypes");
            DropTable("dbo.Profiles");
            DropTable("dbo.ComplaintTypes");
            DropTable("dbo.ComplaintStatus");
            DropTable("dbo.Complaints");
        }
    }
}
