namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skypeid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SkypeId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SkypeId");
        }
    }
}
