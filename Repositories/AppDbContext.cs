using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options) // primary constructor
    {
        public DbSet<Product> Products { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // IEntityTypeConfiguration implement eden tum siniflari alir

            base.OnModelCreating(modelBuilder);
        }
    }
}
