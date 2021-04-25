using LazyAbp.FeedbackKit.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(FeedbackKitEntityFrameworkCoreTestModule)
        )]
    public class FeedbackKitDomainTestModule : AbpModule
    {
        
    }
}
