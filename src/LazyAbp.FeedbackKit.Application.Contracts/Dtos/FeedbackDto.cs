using System;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.FeedbackKit.Dtos
{
    [Serializable]
    public class FeedbackDto : FullAuditedEntityDto<Guid>
    {
        public string Module { get; set; }

        public string Company { get; set; }

        public string Contact { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public bool IsReply { get; set; }

        public string ReplyContent { get; set; }
    }
}