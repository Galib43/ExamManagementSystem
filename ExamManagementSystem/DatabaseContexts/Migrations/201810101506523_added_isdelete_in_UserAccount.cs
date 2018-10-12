namespace DatabaseContexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_isdelete_in_UserAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAcounts", "isDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserAcounts", "isDelete");
        }
    }
}
