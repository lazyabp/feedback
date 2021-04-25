using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit
{
    [DependsOn(
        typeof(FeedbackKitApplicationModule),
        typeof(FeedbackKitDomainTestModule)
        )]
    public class FeedbackKitApplicationTestModule : AbpModule
    {

    }
}
