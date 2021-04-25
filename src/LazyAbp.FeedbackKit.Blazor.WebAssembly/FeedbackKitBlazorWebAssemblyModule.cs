using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit.Blazor.WebAssembly
{
    [DependsOn(
        typeof(FeedbackKitBlazorModule),
        typeof(FeedbackKitHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class FeedbackKitBlazorWebAssemblyModule : AbpModule
    {
        
    }
}