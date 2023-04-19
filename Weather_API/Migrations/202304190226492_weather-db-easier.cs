namespace Weather_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weatherdbeasier : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Forecasts", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Forecasts", "Date", c => c.DateTime(nullable: false));
        }
    }
}
