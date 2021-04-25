using LazyAbp.FeedbackKit.Localization;
using Volo.Abp.Application.Services;

namespace LazyAbp.FeedbackKit
{
    public abstract class FeedbackKitAppService : ApplicationService
    {
        protected FeedbackKitAppService()
        {
            LocalizationResource = typeof(FeedbackKitResource);
            ObjectMapperContext = typeof(FeedbackKitApplicationModule);
        }
    }
}
