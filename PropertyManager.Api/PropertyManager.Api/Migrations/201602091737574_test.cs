namespace PropertyManager.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "Description", c => c.String());
            DropColumn("dbo.WorkOrders", "Descritopn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "Descritopn", c => c.String());
            DropColumn("dbo.WorkOrders", "Description");
        }
    }
}
