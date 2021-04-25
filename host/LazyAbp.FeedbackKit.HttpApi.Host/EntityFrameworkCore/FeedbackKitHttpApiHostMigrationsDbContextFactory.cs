using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LazyAbp.FeedbackKit.EntityFrameworkCore
{
    public class FeedbackKitHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<FeedbackKitHttpApiHostMigrationsDbContext>
    {
        public FeedbackKitHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FeedbackKitHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("FeedbackKit"));

            return new FeedbackKitHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
