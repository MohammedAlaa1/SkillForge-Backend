using Microsoft.EntityFrameworkCore;
using SkillForge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillForge.Infrastructure.Contexts
{
    public class SkillForgeDbContext : DbContext
    {
        public SkillForgeDbContext(DbContextOptions<SkillForgeDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SkillForgeDbContext).Assembly);
        }
    }
}
