using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LazyAbp.FeedbackKit.EntityFrameworkCore
{
    public class FeedbackKitHttpApiHostMigrationsDbContext : AbpDbContext<FeedbackKitHttpApiHostMigrationsDbContext>
    {
        public FeedbackKitHttpApiHostMigrationsDbContext(DbContextOptions<FeedbackKitHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureFeedbackKit();
        }
    }
}
