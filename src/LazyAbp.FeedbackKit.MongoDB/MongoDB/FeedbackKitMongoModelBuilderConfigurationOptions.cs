using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace LazyAbp.FeedbackKit.MongoDB
{
    public class FeedbackKitMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public FeedbackKitMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}