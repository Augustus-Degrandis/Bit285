namespace VisitorLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 4000),
                        LoginTime = c.DateTime(nullable: false),
                        IpAdress = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
