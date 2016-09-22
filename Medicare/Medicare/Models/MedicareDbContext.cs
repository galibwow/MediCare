using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Medicare.Models
{
    public class MedicareDbContext:DbContext
    {


        public MedicareDbContext() : base("name=MedicareDbContext") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Manufacturar> Manufacturars { get; set; }
        public DbSet<Groups> Groupses { get; set; }
        

        public DbSet<BuyProduct> BuyProducts { get; set; }
        public DbSet<Payment> Payments { get; set; } 
        
    }
}