using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Eav;
using svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Core;
using svietnamAPI.Infras.Data.DatabaseContext.EntityConfigs.Eav;

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

            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new CommuneConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new DataTypeConfig());
            modelBuilder.ApplyConfiguration(new DistrictConfig());
            modelBuilder.ApplyConfiguration(new DocumentConfig());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfig());
            modelBuilder.ApplyConfiguration(new EntityStatusConfig());
            modelBuilder.ApplyConfiguration(new EntityTypeConfig());
            modelBuilder.ApplyConfiguration(new ProvinceConfig());

            //
            //  Eav
            //

            modelBuilder.ApplyConfiguration(new EavAttributeConfig());
            modelBuilder.ApplyConfiguration(new EavAttributeEavAttributeSetMappingConfig());
            modelBuilder.ApplyConfiguration(new EavAttributeGroupConfig());
            modelBuilder.ApplyConfiguration(new EavAttributeSetConfig());
            modelBuilder.ApplyConfiguration(new EavAttributeValueConfig());

            //
            //  Catalog
            //

            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ManufacturerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductItemConfig());
            modelBuilder.ApplyConfiguration(new ProductItemDetailConfig());
            modelBuilder.ApplyConfiguration(new SupplierConfig());
        }

        //
        //  Core
        //

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<EntityStatus> EntityStatuses { get; set; }
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Province> Provinces { get; set; }

        //
        //  Eav
        //

        public DbSet<EavAttribute> EavAttributes { get; set; }
        public DbSet<EavAttributeEavAttributeSetMapping> EavAttributeEavAttributeSetMappings { get; set; }
        public DbSet<EavAttributeGroup> EavAttributeGroups { get; set; }
        public DbSet<EavAttributeSet> EavAttributeSets { get; set; }

        //
        //  Catalog
        //

        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<ProductItemDetail> ProductItemDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}