using Microsoft.EntityFrameworkCore;

namespace GetDataFromAzureDb.Models
{
    public partial class GetDataFromAzureDbContext : DbContext
    {
        public GetDataFromAzureDbContext()
        {

        }
        public GetDataFromAzureDbContext(DbContextOptions<GetDataFromAzureDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployee> tblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=tcp:employeedbserverr.database.windows.net,1433;Initial Catalog=EmployeeDB;Persist Security Info=False;User ID=employeedbadmin;Password=Seda123456.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
