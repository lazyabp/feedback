using Lazy.Abp.FeedbackKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.FeedbackKit
{
    public abstract class FeedbackKitController : AbpController
    {
        protected FeedbackKitController()
        {
            LocalizationResource = typeof(FeedbackKitResource);
        }
    }
}
