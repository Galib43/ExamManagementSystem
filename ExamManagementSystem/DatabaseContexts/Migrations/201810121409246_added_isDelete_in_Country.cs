namespace DatabaseContexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_isDelete_in_Country : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "isDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "isDelete");
        }
    }
}
