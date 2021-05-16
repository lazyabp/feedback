using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.FeedbackKit.Dtos
{
    public class FeedbackListRequestDto : PagedAndSortedResultRequestDto
    {
        public string Module { get; set; }

        public bool? IsReply { get; set; }

        public DateTime? CreationAfter { get; set; }

        public DateTime? CreationBefore { get; set; }

        public string Filter { get; set; }
    }
}
