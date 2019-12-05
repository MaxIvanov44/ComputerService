namespace Database.EntityModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Masters> Masters { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Clients)
                .HasForeignKey(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Computers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Computers)
                .HasForeignKey(e => e.computer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Masters>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Masters)
                .HasForeignKey(e => e.master)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.order_status)
                .WillCascadeOnDelete(false);
        }
    }
}
