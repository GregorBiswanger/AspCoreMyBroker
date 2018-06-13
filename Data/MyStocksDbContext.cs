using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBroker.Data
{
    public class MyStocksDbContext : DbContext
    {
        public DbSet<MyStock> Stocknames { get; set; }

        public MyStocksDbContext(DbContextOptions options) : base(options) { }
    }
}
