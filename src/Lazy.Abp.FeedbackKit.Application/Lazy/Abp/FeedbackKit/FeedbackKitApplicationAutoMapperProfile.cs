using Lazy.Abp.FeedbackKit;
using Lazy.Abp.FeedbackKit.Dtos;
using AutoMapper;

namespace Lazy.Abp.FeedbackKit
{
    public class FeedbackKitApplicationAutoMapperProfile : Profile
    {
        public FeedbackKitApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Feedback, FeedbackDto>();
            CreateMap<FeedbackCreateUpdateDto, Feedback>(MemberList.Source);
        }
    }
}
