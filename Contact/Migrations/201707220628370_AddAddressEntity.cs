namespace ContactMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressEntity : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.BasicEntities", new[] { "Email" });
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Address1 = c.String(maxLength: 50),
                        Address2 = c.String(maxLength: 50),
                        Suburb = c.String(nullable: false, maxLength: 20),
                        City = c.String(maxLength: 20),
                        PostCode = c.String(nullable: false, maxLength: 4),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
            DropTable("dbo.BasicEntities");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.EntityId);
            
            DropForeignKey("dbo.Addresses", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Addresses", new[] { "ContactId" });
            DropTable("dbo.Addresses");
            CreateIndex("dbo.BasicEntities", "Email", unique: true);
        }
    }
}
