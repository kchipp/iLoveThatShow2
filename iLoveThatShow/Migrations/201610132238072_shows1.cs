namespace iLoveThatShow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shows1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        ShowName = c.String(),
                        ShowType = c.String(),
                        Network = c.String(),
                    })
                .PrimaryKey(t => t.ShowId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shows");
        }
    }
}
