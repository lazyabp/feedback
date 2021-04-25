using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace LazyAbp.FeedbackKit
{
    public interface IFeedbackRepository : IRepository<Feedback, Guid>
    {
        Task<int> GetCountAsync(
            Guid? userId = null,
            string module = null,
            bool? isReply = null,
            DateTime? creationAfter = null,
            DateTime? creationBefore = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<Feedback>> GetListAsync(
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
        );
    }
}