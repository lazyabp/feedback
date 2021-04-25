using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(FeedbackKitBlazorModule)
        )]
    public class FeedbackKitBlazorServerModule : AbpModule
    {
        
    }
}