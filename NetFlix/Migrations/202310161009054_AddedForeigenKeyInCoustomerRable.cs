namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeigenKeyInCoustomerRable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coustomers", "membersShipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Coustomers", "membersShipTypeId");
            AddForeignKey("dbo.Coustomers", "membersShipTypeId", "dbo.MembersShipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coustomers", "membersShipTypeId", "dbo.MembersShipTypes");
            DropIndex("dbo.Coustomers", new[] { "membersShipTypeId" });
            DropColumn("dbo.Coustomers", "membersShipTypeId");
        }
    }
}
