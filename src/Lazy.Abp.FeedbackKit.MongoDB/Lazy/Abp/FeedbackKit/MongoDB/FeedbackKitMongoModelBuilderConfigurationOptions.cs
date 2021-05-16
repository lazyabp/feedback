using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.FeedbackKit.MongoDB
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