namespace Weather_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weatherdb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Forecasts", "Temp", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forecasts", "Temp", c => c.Int(nullable: false));
        }
    }
}
