namespace ContactMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCorrespondenceField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "CorrespondenceByEmail", c => c.Boolean(nullable: false));
            DropColumn("dbo.Contacts", "CorrespondanceByEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "CorrespondanceByEmail", c => c.Boolean(nullable: false));
            DropColumn("dbo.Contacts", "CorrespondenceByEmail");
        }
    }
}
