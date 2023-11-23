namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAuditFieldInmembershiptypecoloum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembersShipTypes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.MembersShipTypes", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.MembersShipTypes", "UpdatedOn", c => c.DateTime());
            AddColumn("dbo.MembersShipTypes", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.MembersShipTypes", "CreatedBy", c => c.String());
            AddColumn("dbo.MembersShipTypes", "UpdatedBy", c => c.String());
            AddColumn("dbo.MembersShipTypes", "DeletedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembersShipTypes", "DeletedBy");
            DropColumn("dbo.MembersShipTypes", "UpdatedBy");
            DropColumn("dbo.MembersShipTypes", "CreatedBy");
            DropColumn("dbo.MembersShipTypes", "DeletedOn");
            DropColumn("dbo.MembersShipTypes", "UpdatedOn");
            DropColumn("dbo.MembersShipTypes", "CreatedOn");
            DropColumn("dbo.MembersShipTypes", "IsActive");
        }
    }
}
