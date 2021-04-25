using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using LazyAbp.FeedbackKit;

namespace LazyAbp.FeedbackKit.EntityFrameworkCore
{
    [ConnectionStringName(FeedbackKitDbProperties.ConnectionStringName)]
    public interface IFeedbackKitDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Feedback> Feedbacks { get; set; }
    }
}
