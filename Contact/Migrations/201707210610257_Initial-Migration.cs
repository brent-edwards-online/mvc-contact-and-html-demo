namespace ContactMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BasicEntities",
                c => new
                    {
                        EntityId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Gender = c.Boolean(nullable: false),
                        BasicInformation = c.String(maxLength: 1000),
                        TermsAndConditionsAccepted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EntityId)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false, maxLength: 1),
                        DOB = c.DateTime(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.BasicEntities", new[] { "Email" });
            DropTable("dbo.Contacts");
            DropTable("dbo.BasicEntities");
        }
    }
}
