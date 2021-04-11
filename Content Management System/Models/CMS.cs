namespace Content_Management_System.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CMS : DbContext
    {
        public CMS()
            : base("name=CMS")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<FarmersTraining> FarmersTrainings { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<TrainingApplications> TrainingApplications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FarmersTraining>()
                .Property(e => e.TrainerName)
                .IsUnicode(false);

            modelBuilder.Entity<FarmersTraining>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<FarmersTraining>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);
        }
    }
}
