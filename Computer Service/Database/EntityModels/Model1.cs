namespace Database.EntityModels
{
    using System.Data.Entity;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Masters> Masters { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusManager> StatusManager { get; set; }
        public virtual DbSet<StatusMaster> StatusMaster { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UnlockRequest> UnlockRequest { get; set; }
        public virtual DbSet<Details> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Clients)
                .HasForeignKey(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Masters>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Masters)
                .HasForeignKey(e => e.master)
                .WillCascadeOnDelete(false);
        }
    }
}