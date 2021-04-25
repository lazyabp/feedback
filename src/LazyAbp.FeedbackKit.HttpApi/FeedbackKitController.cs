using LazyAbp.FeedbackKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LazyAbp.FeedbackKit
{
    public abstract class FeedbackKitController : AbpController
    {
        protected FeedbackKitController()
        {
            LocalizationResource = typeof(FeedbackKitResource);
        }
    }
}
