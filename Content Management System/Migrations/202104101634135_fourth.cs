namespace Content_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TrainingApplications", "EventName", c => c.String(nullable: false));
            //DropColumn("dbo.TrainingApplications", "Event");
        }
        
        public override void Down()
        {
            //    AddColumn("dbo.TrainingApplications", "Event", c => c.String(nullable: false));
            //    DropColumn("dbo.TrainingApplications", "EventName");
        }
    }
}
