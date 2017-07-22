namespace ContactMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHighestQualification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "HighestQualification", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "Password", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Password", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Contacts", "HighestQualification");
        }
    }
}
