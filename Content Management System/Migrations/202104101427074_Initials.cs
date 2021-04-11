namespace Content_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initials : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.__MigrationHistory",
            //    c => new
            //        {
            //            MigrationId = c.String(nullable: false, maxLength: 150),
            //            ContextKey = c.String(nullable: false, maxLength: 300),
            //            Model = c.Binary(nullable: false),
            //            ProductVersion = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => new { t.MigrationId, t.ContextKey });
            
            //CreateTable(
            //    "dbo.FarmersTraining",
            //    c => new
            //        {
            //            TrainingId = c.Int(nullable: false, identity: true),
            //            TrainerName = c.String(nullable: false, maxLength: 200, unicode: false),
            //            EventName = c.String(nullable: false, maxLength: 100, unicode: false),
            //            Description = c.String(nullable: false, unicode: false),
            //            TrainingTime = c.DateTime(nullable: false, storeType: "smalldatetime"),
            //        })
            //    .PrimaryKey(t => t.TrainingId);
            
            //CreateTable(
            //    "dbo.Login",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserName = c.String(nullable: false, maxLength: 100, unicode: false),
            //            Password = c.String(nullable: false, maxLength: 100, unicode: false),
            //            CreatedBy = c.String(maxLength: 50, unicode: false),
            //            CreatedOn = c.DateTime(storeType: "smalldatetime"),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.TrainingApplications",
            //    c => new
            //        {
            //            ApplicationId = c.Int(nullable: false, identity: true),
            //            Event = c.String(nullable: false),
            //            email = c.String(nullable: false),
            //            FirstName = c.String(nullable: false),
            //            LastName = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.TrainingApplications");
            //DropTable("dbo.Login");
            //DropTable("dbo.FarmersTraining");
            //DropTable("dbo.__MigrationHistory");
        }
    }
}
