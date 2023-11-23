namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedisactivecoloumincoustomertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coustomers", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coustomers", "IsActive");
        }
    }
}
