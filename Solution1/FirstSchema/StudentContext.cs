using Microsoft.EntityFrameworkCore;

namespace FirstSchema
{
    public class StudentContext : DbContext
    {
        internal string Schema = "student";
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


            optionsBuilder.UseSqlServer(connectionString, s => s.MigrationsHistoryTable("StudentMigration", Schema));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);

            base.OnModelCreating(modelBuilder);
        }
    }
}
