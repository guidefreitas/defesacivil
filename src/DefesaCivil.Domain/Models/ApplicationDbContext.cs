using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity.Infrastructure;

namespace DefesaCivil.Domain.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
            if (!_created)
            {
                //Database.AsMigrationsEnabled().ApplyMigrations();
                _created = true;
            }
        }
        //public DbSet<Blog> Blogs { get; set; }
        private static bool _created = false;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
       
    }
}
