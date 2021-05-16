using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.FeedbackKit.MongoDB
{
    [ConnectionStringName(FeedbackKitDbProperties.ConnectionStringName)]
    public class FeedbackKitMongoDbContext : AbpMongoDbContext, IFeedbackKitMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureFeedbackKit();
        }
    }
}