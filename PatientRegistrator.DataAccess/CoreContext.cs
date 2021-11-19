namespace PatientRegistrator.DataAccess
{
    using Microsoft.EntityFrameworkCore;

    using PatientRegistrator.Model;

    public class CoreContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=PatientRegistrator.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}