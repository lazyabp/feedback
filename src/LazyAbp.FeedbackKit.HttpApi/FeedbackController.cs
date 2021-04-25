using LazyAbp.FeedbackKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.FeedbackKit
{
    [RemoteService(Name = "FeedbackKit")]
    [Area("feedbackkit")]
    [ControllerName("Feedback")]
    [Route("api/feedbackkit/feedbacks")]
    public class FeedbackController : FeedbackKitController, IFeedbackAppService
    {
        private readonly IFeedbackAppService _service;

        public FeedbackController(IFeedbackAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<FeedbackDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<FeedbackDto>> GetListAsync(GetFeedbackListRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpGet]
        [Route("management")]
        public Task<PagedResultDto<FeedbackDto>> GetManagementListAsync(GetFeedbackListRequestDto input)
        {
            return _service.GetManagementListAsync(input);
        }

        [HttpPost]
        public Task<FeedbackDto> CreateAsync(CreateUpdateFeedbackDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}
