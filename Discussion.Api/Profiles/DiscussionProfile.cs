using AutoMapper;
using System.Linq;

namespace Discussion.Api.Profiles
{
    public class DiscussionProfile : Profile
    {
        public DiscussionProfile()
        {
            CreateMap<Data.Entities.Discussion, Models.ViewModels.Discussion.DiscussionDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id)
                )
                .ForMember(
                    dest => dest.Colleagues,
                    opt => opt.MapFrom(src => src.DiscussionUsers.Select(d => d.User))
                )
                .ForMember(
                    dest => dest.Date,
                    opt => opt.MapFrom(src => src.Date)
                )
                .ForMember(
                    dest => dest.Location,
                    opt => opt.MapFrom(src => src.Location)
                )
                .ForMember(
                    dest => dest.Subject,
                    opt => opt.MapFrom(src => src.Subject)
                )
                .ForMember(
                    dest => dest.Outcomes,
                    opt => opt.MapFrom(src => src.Outcomes)
                )
                .ForMember(
                    dest => dest.Observer,
                    opt => opt.MapFrom(src => src.Observer)
                );
            CreateMap<Data.Entities.Discussion, Models.ViewModels.Discussion.GetDiscussionDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id)
                )
                .ForMember(
                    dest => dest.ColleaugesId,
                    opt => opt.MapFrom(src => src.DiscussionUsers.Select(d => d.User).Select(u => u.Id))
                )
                .ForMember(
                    dest => dest.Date,
                    opt => opt.MapFrom(src => src.Date)
                )
                .ForMember(
                    dest => dest.Location,
                    opt => opt.MapFrom(src => src.Location)
                )
                .ForMember(
                    dest => dest.Subject,
                    opt => opt.MapFrom(src => src.Subject)
                )
                .ForMember(
                    dest => dest.Outcomes,
                    opt => opt.MapFrom(src => src.Outcomes)
                )
                .ForMember(
                    dest => dest.ObserverId,
                    opt => opt.MapFrom(src => src.ObserverId)
                );
        }
    }
}
