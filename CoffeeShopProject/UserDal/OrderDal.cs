using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeShopProject.UserDal
{
    public class OrderDal: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDal>().ToTable("Order");
        }
        public DbSet<OrderDal> Orders { get; set; }
    }
}