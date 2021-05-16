using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.FeedbackKit.MongoDB
{
    [ConnectionStringName(FeedbackKitDbProperties.ConnectionStringName)]
    public interface IFeedbackKitMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
