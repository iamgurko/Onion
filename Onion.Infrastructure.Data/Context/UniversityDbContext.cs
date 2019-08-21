using Microsoft.EntityFrameworkCore;
using Onion.Domain.Models;
using System;

namespace Onion.Infrastructure.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options){}
        public DbSet<Course> Courses { get; set; }
    }
}
