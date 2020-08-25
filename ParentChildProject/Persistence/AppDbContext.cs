using Microsoft.EntityFrameworkCore;
using ParentChildProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentChildProject.Persistence
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Childs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>()
                .HasMany(c => c.Childs)
                .WithOne(p => p.Parent);
        }
    }
}
