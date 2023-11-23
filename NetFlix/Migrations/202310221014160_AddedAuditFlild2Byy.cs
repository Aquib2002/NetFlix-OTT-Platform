namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAuditFlild2Byy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coustomers", "CreatedBy", c => c.String());
            AddColumn("dbo.Coustomers", "UpdatedBy", c => c.String());
            AddColumn("dbo.Coustomers", "DeletedBy", c => c.String());
            DropColumn("dbo.Coustomers", "UpdatedOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coustomers", "UpdatedOn", c => c.DateTime());
            DropColumn("dbo.Coustomers", "DeletedBy");
            DropColumn("dbo.Coustomers", "UpdatedBy");
            DropColumn("dbo.Coustomers", "CreatedBy");
        }
    }
}
