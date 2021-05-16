using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.FeedbackKit.MongoDB
{
    public static class FeedbackKitMongoDbContextExtensions
    {
        public static void ConfigureFeedbackKit(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new FeedbackKitMongoModelBuilderConfigurationOptions(
                FeedbackKitDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}