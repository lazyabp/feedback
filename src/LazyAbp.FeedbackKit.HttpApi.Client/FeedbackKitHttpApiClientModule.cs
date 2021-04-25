using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit
{
    [DependsOn(
        typeof(FeedbackKitApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class FeedbackKitHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "FeedbackKit";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(FeedbackKitApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
