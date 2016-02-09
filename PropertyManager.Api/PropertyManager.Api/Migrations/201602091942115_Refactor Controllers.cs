namespace PropertyManager.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorControllers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "Description", c => c.String());
            DropColumn("dbo.WorkOrders", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "Description", c => c.String());
            DropColumn("dbo.WorkOrders", "Description");
        }
    }
}
