using AutoMapper;
using Discussion.Data.Entities;
namespace Discussion.Api.Profiles
{
    public class DiscussionUserProfile : Profile
    {
        public DiscussionUserProfile()
        {
            CreateMap<DiscussionUser, Models.ViewModels.Discussion.DiscussionUserDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id)
                )
                .ForMember(
                    dest => dest.User,
                    opt => opt.MapFrom(src => src.User)
                );
        }
    }
}
