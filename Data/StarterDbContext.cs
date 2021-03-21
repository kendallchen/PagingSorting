using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;

namespace Data
{
    public class StarterDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public StarterDbContext(DbContextOptions<StarterDbContext> options)
            : base(options)
        {
        }
    }
}
