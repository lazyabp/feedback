using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit
{
    [DependsOn(
        typeof(FeedbackKitHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class FeedbackKitConsoleApiClientModule : AbpModule
    {
        
    }
}
