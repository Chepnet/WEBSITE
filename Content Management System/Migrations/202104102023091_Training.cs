namespace Content_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Training : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrainingApplications", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.TrainingApplications", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.TrainingApplications", "email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainingApplications", "email", c => c.String(nullable: false));
            AlterColumn("dbo.TrainingApplications", "LastName", c => c.String());
            AlterColumn("dbo.TrainingApplications", "FirstName", c => c.String());
        }
    }
}
