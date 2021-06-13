using System;
using Lazy.Abp.FeedbackKit.Permissions;
using Lazy.Abp.FeedbackKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Users;
using System.Collections.Generic;

namespace Lazy.Abp.FeedbackKit
{
    [Authorize]
    public class FeedbackAppService : ApplicationService, IFeedbackAppService
    {
        private readonly IFeedbackRepository _repository;
        
        public FeedbackAppService(IFeedbackRepository repository)
        {
            _repository = repository;
        }

        public async Task<FeedbackDto> GetAsync(Guid id)
        {
            var feedback = await _repository.GetAsync(id);

            return ObjectMapper.Map<Feedback, FeedbackDto>(feedback);
        }

        public async Task<PagedResultDto<FeedbackDto>> GetListAsync(FeedbackListRequestDto input)
        {
            var count = await _repository.GetCountAsync(CurrentUser.GetId(), input.Module, input.IsReply, input.CreationAfter, input.CreationBefore, input.Filter);
            var list = await _repository.GetListAsync(CurrentUser.GetId(), input.Module, input.IsReply, input.CreationAfter, input.CreationBefore, input.Filter, input.MaxResultCount, input.SkipCount, input.Sorting);

            return new PagedResultDto<FeedbackDto>(
                count,
                ObjectMapper.Map<List<Feedback>, List<FeedbackDto>>(list)
            );
        }

        [Authorize(FeedbackKitPermissions.Feedback.Management)]
        public async Task<PagedResultDto<FeedbackDto>> GetManagementListAsync(FeedbackListRequestDto input)
        {
            var count = await _repository.GetCountAsync(null, input.Module, input.IsReply, input.CreationAfter, input.CreationBefore, input.Filter);
            var list = await _repository.GetListAsync(null, input.Module, input.IsReply, input.CreationAfter, input.CreationBefore, input.Filter, input.MaxResultCount, input.SkipCount, input.Sorting);

            return new PagedResultDto<FeedbackDto>(
                count,
                ObjectMapper.Map<List<Feedback>, List<FeedbackDto>>(list)
            );
        }

        [Authorize(FeedbackKitPermissions.Feedback.Reply)]
        public async Task<FeedbackDto> ReplyAsync(Guid id, ReplyDto input)
        {
            var feedback = await _repository.GetAsync(id);
            feedback.SetAsRepled(input.Content);

            return ObjectMapper.Map<Feedback, FeedbackDto>(feedback);
        }

        public async Task<FeedbackDto> CreateAsync(FeedbackCreateUpdateDto input)
        {
            var feedback = new Feedback(GuidGenerator.Create(), CurrentTenant.Id, input.Module, input.Company,
                input.Contact, input.Telephone, input.Email, input.Subject, input.Contact, false, "");

            await _repository.InsertAsync(feedback);

            return ObjectMapper.Map<Feedback, FeedbackDto>(feedback);
        }

        public async Task DeleteAsync(Guid id)
        {
            var feedback = await _repository.GetAsync(id);

            if (feedback.CreatorId == CurrentUser.GetId())
            {
                await _repository.DeleteAsync(id);
                return;
            }

            await AuthorizationService.CheckAsync(FeedbackKitPermissions.Feedback.Default);
            await _repository.DeleteAsync(id);
        }
    }
}
