using Localization.Resources.AbpUi;
using Lazy.Abp.FeedbackKit.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Lazy.Abp.FeedbackKit
{
    [DependsOn(
        typeof(FeedbackKitApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class FeedbackKitHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(FeedbackKitHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<FeedbackKitResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
