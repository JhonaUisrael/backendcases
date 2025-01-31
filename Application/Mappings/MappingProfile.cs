using AutoMapper;
using Domain;

namespace Application;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
         CreateMap<CaseCreateDto, Case>()
            .ForMember(dest => dest.CaseDescription, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.CaseTypeId, opt => opt.MapFrom(src => src.Type))
            .ForMember(dest => dest.CaseStartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.CaseEndDate, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.CasePriority, opt => opt.MapFrom(src => src.Priority));

    }

}
