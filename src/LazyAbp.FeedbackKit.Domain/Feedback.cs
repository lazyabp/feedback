using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace LazyAbp.FeedbackKit
{
    public class Feedback : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; protected set; }

        /// <summary>
        /// 评论所在模块
        /// </summary>
        [NotNull]
        [MaxLength(FeedbackConsts.MaxModuleLength)]
        public string Module { get; private set; }

        public string Company { get; private set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [MaxLength(FeedbackConsts.MaxContactLength)]
        public string Contact { get; private set; }

        [MaxLength(FeedbackConsts.MaxTelephoneLength)]
        public string Telephone { get; private set; }

        [MaxLength(FeedbackConsts.MaxEmailLength)]
        public string Email { get; private set; }

        [MaxLength(FeedbackConsts.MaxSubjectLength)]
        public string Subject { get; private set; }

        [MaxLength(FeedbackConsts.MaxContentLength)]
        public string Content { get; private set; }

        public bool IsReply { get; private set; }

        public string ReplyContent { get; private set; }

        protected Feedback()
        {
        }

        public Feedback(
            Guid id,
            Guid? tenantId,
            string module,
            string company,
            string contact,
            string telephone,
            string email,
            string subject,
            string content,
            bool isReply,
            string replyContent
        ) : base(id)
        {
            TenantId = tenantId;
            Module = module;
            Company = company;
            Contact = contact;
            Telephone = telephone;
            Email = email;
            Subject = subject;
            Content = content;
            IsReply = isReply;
            ReplyContent = replyContent;
        }

        public void SetAsRepled (string replyContent)
        {
            IsReply = true;
            ReplyContent = replyContent;
        }
    }
}
