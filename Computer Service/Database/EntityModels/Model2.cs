namespace Database.EntityModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Masters> Masters { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusManager> StatusManager { get; set; }
        public virtual DbSet<StatusMaster> StatusMaster { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
