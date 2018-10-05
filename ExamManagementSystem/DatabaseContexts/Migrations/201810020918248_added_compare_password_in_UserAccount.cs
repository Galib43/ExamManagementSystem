namespace DatabaseContexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_compare_password_in_UserAccount : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserAcounts", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserAcounts", "ConfirmPassword", c => c.String(nullable: false));
        }
    }
}
