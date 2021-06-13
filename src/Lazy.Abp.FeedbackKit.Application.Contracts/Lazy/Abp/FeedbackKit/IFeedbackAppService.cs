using System;
using System.Threading.Tasks;
using Lazy.Abp.FeedbackKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.FeedbackKit
{
    public interface IFeedbackAppService : IApplicationService
    {
        Task<FeedbackDto> GetAsync(Guid id);

        Task<PagedResultDto<FeedbackDto>> GetListAsync(FeedbackListRequestDto input);
        
        Task<PagedResultDto<FeedbackDto>> GetManagementListAsync(FeedbackListRequestDto input);

        Task<FeedbackDto> ReplyAsync(Guid id, ReplyDto input);

        Task<FeedbackDto> CreateAsync(FeedbackCreateUpdateDto input);

        Task DeleteAsync(Guid id);
    }
}