using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6Examples.CodeFirst.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().ToTable("ProductTable", "products");

            modelBuilder.Entity<Product>().Property(x=>x.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(x=>x.Price).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Product>().Property(x=>x.Stock).IsRequired();
            modelBuilder.Entity<Product>().Property(x=>x.Barcode).IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        //public override int SaveChanges()
        //{
        //    ChangeTracker.Entries().ToList().ForEach(e =>
        //    {
        //        if (e.Entity is Product p)
        //        {
        //            if (e.State == EntityState.Added)
        //                p.CreatedDate = DateTime.Now;
        //        }
        //    });

        //    return base.SaveChanges();
        //}
    }
}
