namespace iLoveThatShow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class udpatetoshow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shows", "AirDay", c => c.String());
            AddColumn("dbo.Shows", "AirTime", c => c.String());
            AddColumn("dbo.Shows", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shows", "Description");
            DropColumn("dbo.Shows", "AirTime");
            DropColumn("dbo.Shows", "AirDay");
        }
    }
}
