using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace LazyAbp.FeedbackKit.MongoDB
{
    [ConnectionStringName(FeedbackKitDbProperties.ConnectionStringName)]
    public interface IFeedbackKitMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
