using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        private readonly ILogger<AppDbContext> _logger;

        //static LoggerFactory object
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options, ILogger<AppDbContext> logger) : base(options)
        {
            _logger = logger;
            _logger.LogInformation("Starting to create AppDbContext...");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory)  //tie-up DbContext with LoggerFactory object
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            //  Core
            //

            modelBuilder.ApplyConfiguration(new DocumentTypeConfig());
            modelBuilder.ApplyConfiguration(new DocumentConfig());

            //
            // Catalog
            //

            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }

        //
        //  Catalog
        //

        public DbSet<Category> Categories { get; set; }

        //
        //  Core
        //
    }
}