using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRSserver.Models;

namespace PRSserver.Data
{
    public class PRSserverContext : DbContext
    {
        public PRSserverContext (DbContextOptions<PRSserverContext> options)
            : base(options)
        {
        }

        public DbSet<PRSserver.Models.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>(e => {
                e.HasIndex("UserName").IsUnique();
            });
        }

    }

    
}
