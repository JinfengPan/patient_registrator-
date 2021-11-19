//namespace PatientRegistrator.DataAccess
//{
//    using System.IO;

//    using Microsoft.EntityFrameworkCore;

//    using PatientRegistrator.Model;

//    public class CoreContext : DbContext
//    {
//        public CoreContext(DbContextOptions<CoreContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Patient> Patients { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//        }

//        //public CoreContext CreateDbContext(string[] args)
//        //{
//        //    var optionsBuilder = new DbContextOptionsBuilder<CoreContext>();

//        //    var configuration = new ConfigurationBuilder()
//        //        .SetBasePath(Directory.GetCurrentDirectory())
//        //        .AddJsonFile("appsettings.json")
//        //        .Build();

//        //    var connectionString = configuration.GetConnectionString("sqlConnection");

//        //    optionsBuilder.UseSqlServer(
//        //        connectionString,
//        //        b => b.MigrationsAssembly("Eurofins.Adms.Core.Infrastructure.Entities.Migrations"));

//        //    return new CoreContext(optionsBuilder.Options);
//        //}
//    }
//}