using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CoffeeShopProject.Models;
namespace CoffeeShopProject.UserDal
{
    public class CartDal: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart>().ToTable("Cart");
        }
        public DbSet<Products> Carts { get; set; }
        
    }
}

