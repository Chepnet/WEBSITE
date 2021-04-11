namespace Content_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jquery : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.FarmersTraining", "TrainingTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.FarmersTraining", "TrainingTime", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
        }
    }
}
