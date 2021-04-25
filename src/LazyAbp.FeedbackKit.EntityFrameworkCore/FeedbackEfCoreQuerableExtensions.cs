using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LazyAbp.FeedbackKit
{
    public static class FeedbackEfCoreQueryableExtensions
    {
        public static IQueryable<Feedback> IncludeDetails(this IQueryable<Feedback> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}