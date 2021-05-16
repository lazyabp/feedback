using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lazy.Abp.FeedbackKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(FeedbackKitDomainSharedModule)
    )]
    public class FeedbackKitDomainModule : AbpModule
    {

    }
}
