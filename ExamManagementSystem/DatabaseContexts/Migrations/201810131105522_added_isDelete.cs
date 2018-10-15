namespace DatabaseContexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_isDelete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExamTypes", "isDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExamTypes", "isDelete");
        }
    }
}
