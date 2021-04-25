using LazyAbp.FeedbackKit;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit.EntityFrameworkCore
{
    [DependsOn(
        typeof(FeedbackKitDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class FeedbackKitEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FeedbackKitDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Feedback, FeedbackRepository>();
            });
        }
    }
}
