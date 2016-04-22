namespace SERVICE.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ServiceModel : DbContext
    {
        public ServiceModel()
            : base("name=ServiceModel")
        {
        }

        public virtual DbSet<REGION> REGIONS { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<PERSON> CITIZENS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<REGION>()
                .HasMany(e => e.PERSONS)
                .WithRequired(e => e.REGION)
                .HasForeignKey(e => e.REGION_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);
        }
    }
}
