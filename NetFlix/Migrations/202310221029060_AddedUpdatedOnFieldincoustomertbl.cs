namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUpdatedOnFieldincoustomertbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coustomers", "UpdatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coustomers", "UpdatedOn");
        }
    }
}
