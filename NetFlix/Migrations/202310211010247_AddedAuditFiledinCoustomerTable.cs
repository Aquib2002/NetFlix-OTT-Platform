namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAuditFiledinCoustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coustomers", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Coustomers", "UpdatedOn", c => c.DateTime());
            AddColumn("dbo.Coustomers", "DeletedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coustomers", "DeletedOn");
            DropColumn("dbo.Coustomers", "UpdatedOn");
            DropColumn("dbo.Coustomers", "CreatedOn");
        }
    }
}
