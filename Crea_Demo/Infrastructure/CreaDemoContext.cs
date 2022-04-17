using System;
using Crea_Demo.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Crea_Demo.Infrastructure
{
	public class CreaDemoContext : IdentityDbContext<IdentityUser>
    {
        public CreaDemoContext(DbContextOptions<CreaDemoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Community> Communities { get; set; }
        public virtual DbSet<Enrolment> Enrolments { get; set; }
    }
}

