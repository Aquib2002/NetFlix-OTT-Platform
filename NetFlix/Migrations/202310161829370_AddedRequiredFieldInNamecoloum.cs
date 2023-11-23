namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredFieldInNamecoloum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coustomers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coustomers", "Name", c => c.String());
        }
    }
}
