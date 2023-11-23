namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTableinDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MembersShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Duration = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MembersShipTypes");
            DropTable("dbo.Coustomers");
        }
    }
}
