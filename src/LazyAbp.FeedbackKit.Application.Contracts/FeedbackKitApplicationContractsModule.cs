using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace LazyAbp.FeedbackKit
{
    [DependsOn(
        typeof(FeedbackKitDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class FeedbackKitApplicationContractsModule : AbpModule
    {

    }
}
