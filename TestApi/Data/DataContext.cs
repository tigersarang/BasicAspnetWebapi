using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Customer> Customers { get; set; }
    }
}