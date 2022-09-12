using DealershipApplication.Interfaces;
using DealershipDatabase.EntityTypeConfigurations;
using DealershipDomain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDatabase
{
    public class AppDbContext : IdentityDbContext<Customer>, IAppDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CustomerOffers> CustomerOffers { get; set; }
        public DbSet<Dealership> Dealerships { get; set; }
        public DbSet<DealershipCustomerSales> DealershipCustomerSales { get; set; }
        public DbSet<DealershipDiscount> DealershipDiscounts { get; set; }
        public DbSet<DealershipModels> DealershipModels { get; set; }
        public DbSet<RegularDealershipCustomers> RegularDealershipCustomers { get; set; }
        public DbSet<RegularSupplierDealerships> RegularSupplierDealerships { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierCars> SupplierCars { get; set; }
        public DbSet<SupplierDealershipSales> SupplierDealershipSales { get; set; }
        public DbSet<SupplierDiscount> SupplierDiscounts { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
}
