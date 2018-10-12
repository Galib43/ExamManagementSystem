namespace DatabaseContexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_isdelete_in_City : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "isDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "isDelete");
        }
    }
}
