using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using LazyAbp.FeedbackKit.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LazyAbp.FeedbackKit
{
    public class FeedbackRepository : EfCoreRepository<IFeedbackKitDbContext, Feedback, Guid>, IFeedbackRepository
    {
        public FeedbackRepository(IDbContextProvider<IFeedbackKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<int> GetCountAsync(
            Guid? userId = null,
            string module = null,
            bool? isReply = null,
            DateTime? creationAfter = null,
            DateTime? creationBefore = null,
            string filter = null,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetQuery(userId, module, isReply, creationAfter, creationBefore, filter);

            return await query.CountAsync(cancellationToken);
        }

        public async Task<List<Feedback>> GetListAsync(
            Guid? userId = null,
            string module = null,
            bool? isReply = null,
            DateTime? creationAfter = null,
            DateTime? creationBefore = null,
            string filter = null,
            int maxResultCount = 10,
            int skipCount = 0,
            string sorting = null,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetQuery(userId, module, isReply, creationAfter, creationBefore, filter);

            return await query
                .OrderBy(sorting ?? "creationTime DESC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<IQueryable<Feedback>> GetQuery(
            Guid? userId = null,
            string module = null,
            bool? isReply = null,
            DateTime? creationAfter = null,
            DateTime? creationBefore = null,
            string filter = null
        )
        {
            var dbSet = await GetDbSetAsync();

            return dbSet
                .WhereIf(userId.HasValue, e => e.CreatorId == userId)
                .WhereIf(!module.IsNullOrEmpty(), e => e.Module == module)
                .WhereIf(isReply.HasValue, e => e.IsReply == isReply)
                .WhereIf(creationAfter.HasValue, e => e.CreationTime >= creationAfter.Value.Date)
                .WhereIf(creationBefore.HasValue, e => e.CreationTime < creationBefore.Value.AddDays(1).Date)
                .WhereIf(
                    !filter.IsNullOrEmpty(),
                    e => false
                    || e.Company.Contains(filter)
                    || e.Email.Contains(filter)
                    || e.Telephone.Contains(filter)
                );
        }
    }
}