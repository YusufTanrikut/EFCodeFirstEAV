using EFCodeFirstEAV_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstEAV_1.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Ignore(x => x.ID);
            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.ProductID,
                x.OrderID
            });

            modelBuilder.Entity<ProductAttribute>().Ignore(x => x.ID);
            modelBuilder.Entity<ProductAttribute>().HasKey(x => new
            {
                x.ProductID,
                x.AttributeID
            });

            modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<EntityAttribute> EntityAttributes { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }



    }
}
