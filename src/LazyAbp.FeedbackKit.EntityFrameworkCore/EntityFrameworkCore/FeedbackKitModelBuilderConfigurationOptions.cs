using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LazyAbp.FeedbackKit.EntityFrameworkCore
{
    public class FeedbackKitModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public FeedbackKitModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}