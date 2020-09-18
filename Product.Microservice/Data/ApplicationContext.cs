using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Microservice.Data
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<Entities.Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { 

        }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
