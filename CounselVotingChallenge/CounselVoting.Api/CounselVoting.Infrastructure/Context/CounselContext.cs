using CounselVoting.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CounselVoting.Infrastructure.Context
{
    public class CounselContext : DbContext
    {
        public DbSet<SampleModel> Sample { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=CounselVoting.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}