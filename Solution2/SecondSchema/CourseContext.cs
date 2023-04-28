using Microsoft.EntityFrameworkCore;

namespace SecondSchema
{
    public class CourseContext : DbContext
    {
        internal string Schema = "course";
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


            optionsBuilder.UseSqlServer(connectionString, s => s.MigrationsHistoryTable("CourseMigration", Schema));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);

            base.OnModelCreating(modelBuilder);
        }
    }
}
