using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.FeedbackKit.Dtos
{
    public class GetFeedbackListRequestDto : PagedAndSortedResultRequestDto
    {
        public string Module { get; set; }

        public bool? IsReply { get; set; }

        public DateTime? CreationAfter { get; set; }

        public DateTime? CreationBefore { get; set; }

        public string Filter { get; set; }
    }
}
