using System;
using System.Threading.Tasks;
using LazyAbp.FeedbackKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LazyAbp.FeedbackKit
{
    public interface IFeedbackAppService : IApplicationService
    {
        Task<FeedbackDto> GetAsync(Guid id);

        Task<PagedResultDto<FeedbackDto>> GetListAsync(GetFeedbackListRequestDto input);
        
        Task<PagedResultDto<FeedbackDto>> GetManagementListAsync(GetFeedbackListRequestDto input);

        Task<FeedbackDto> CreateAsync(CreateUpdateFeedbackDto input);

        Task DeleteAsync(Guid id);
    }
}