using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using RecruitCat_Username_.Models;


namespace RecruitCat_Username_.Data
{
    public class RecruitCatContext : DbContext
    {
        public RecruitCatContext(DbContextOptions<RecruitCatContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Industry> Industries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=RecruitCatDb;user=root;password=Password;",
            new MySqlServerVersion(new Version(8, 0, 39))); // Ensure version matches your MySQL version
        }
    }
}
