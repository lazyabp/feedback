using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using LazyAbp.FeedbackKit;

namespace LazyAbp.FeedbackKit.EntityFrameworkCore
{
    [ConnectionStringName(FeedbackKitDbProperties.ConnectionStringName)]
    public class FeedbackKitDbContext : AbpDbContext<FeedbackKitDbContext>, IFeedbackKitDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Feedback> Feedbacks { get; set; }

        public FeedbackKitDbContext(DbContextOptions<FeedbackKitDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureFeedbackKit();
        }
    }
}
