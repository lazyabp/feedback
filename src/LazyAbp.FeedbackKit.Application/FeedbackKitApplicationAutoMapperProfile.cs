using LazyAbp.FeedbackKit;
using LazyAbp.FeedbackKit.Dtos;
using AutoMapper;

namespace LazyAbp.FeedbackKit
{
    public class FeedbackKitApplicationAutoMapperProfile : Profile
    {
        public FeedbackKitApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Feedback, FeedbackDto>();
            CreateMap<CreateUpdateFeedbackDto, Feedback>(MemberList.Source);
        }
    }
}
