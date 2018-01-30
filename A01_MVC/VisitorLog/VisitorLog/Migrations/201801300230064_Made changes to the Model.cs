namespace VisitorLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadechangestotheModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Visitors");
            AddColumn("dbo.Visitors", "VisitorID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Visitors", "UserName", c => c.String(maxLength: 4000));
            AddPrimaryKey("dbo.Visitors", "VisitorID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Visitors");
            AlterColumn("dbo.Visitors", "UserName", c => c.String(nullable: false, maxLength: 4000));
            DropColumn("dbo.Visitors", "VisitorID");
            AddPrimaryKey("dbo.Visitors", "UserName");
        }
    }
}
