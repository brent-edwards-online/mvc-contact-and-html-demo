namespace ContactMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCorrespondenceField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "CorrespondanceByEmail", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "CorrespondanceByEmail");
        }
    }
}
