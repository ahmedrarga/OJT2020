namespace PolutionMonitor.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public virtual DbSet<Detector> Detectors { get; set; }
        public virtual DbSet<DetectorsOutput> DetectorsOutputs { get; set; }
        public virtual DbSet<DetectorTpye> DetectorTpyes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Permision> Permisions { get; set; }
        public virtual DbSet<UOM> UOMs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
