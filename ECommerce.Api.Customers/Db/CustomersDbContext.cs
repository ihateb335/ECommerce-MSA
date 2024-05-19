using ECommerce.Api.Orders.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerce.Api.Orders.Db
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CustomersDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
