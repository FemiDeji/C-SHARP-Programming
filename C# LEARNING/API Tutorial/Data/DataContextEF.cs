using Microsoft.EntityFrameworkCore;

namespace APITutorial.Data
{

    public class DataContextEFb : DbContext
    {
        public DbSet<Computer>? Computer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=mssql-180383-0.cloudclusters.net,10030;Database=DotNetCourseDatabase;User Id=Nox;Password=Asd_12345;TrustServerCertificate=true;Connection Timeout=30;"
                    options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");

            modelBuilder.Entity<Computer>();
                .HasNoKey(c => c.ComputerId);
                //.ToTable("Commputer", "TutorialAppSchema");
                //.ToTable("TableName", "SchemaName");
        }
    }
}
