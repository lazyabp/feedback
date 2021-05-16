using Lazy.Abp.FeedbackKit.Localization;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.FeedbackKit
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
