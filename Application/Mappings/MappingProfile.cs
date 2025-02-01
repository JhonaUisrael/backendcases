using AutoMapper;
using Domain;

namespace Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CaseCreateDto, Case>()
           .ConstructUsing(dto => new Case(
               dto.Description,
               dto.Type,
               dto.PersonId,
               dto.ClientId,
               dto.StartDate,
               dto.EndDate,
               dto.Priority
           ));

        CreateMap<Case, CaseViewDto>()
      .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.CaseDescription))
      .ForMember(dest => dest.CaseNumber, opt => opt.MapFrom(src => src.CaseNumber))
      .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.CasePriority))
      .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.CaseState))
      .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.CaseStartDate))
       .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.CaseEndDate))
      .ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.Client))
      .ForMember(dest => dest.AsignedTo, opt => opt.MapFrom(src => src.Person))
      .ForMember(dest => dest.CaseType, opt => opt.MapFrom(src => src.CaseType));



        CreateMap<CasesType, CaseTypeViewDto>()
      .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CaseName));

        CreateMap<Person, PersonViewDto>()
    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.PersonName))
     .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.PersonLastName))
     .ForMember(dest => dest.Identification, opt => opt.MapFrom(src => src.PersonIdentification));

        CreateMap<Client, ClientViewDto>()
    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ClientName))
     .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.ClientLastName))
     .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.ClientPhone))
     .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ClientEmail));


        CreateMap<TaskCaseCreateDto, TaskCase>()
        .ForMember(dest => dest.TaskDetail, opt => opt.MapFrom(src => src.Detail))
       .ForMember(dest => dest.CaseId, opt => opt.MapFrom(src => src.CaseId))
       .ForMember(dest => dest.TaskState, opt => opt.MapFrom(src => src.State));


        CreateMap<TaskCase, TaskCaseViewDto>()
        .ForMember(dest => dest.Detail, opt => opt.MapFrom(src => src.TaskDetail))
       .ForMember(dest => dest.Case, opt => opt.MapFrom(src => src.Case))
       .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
        .ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
        .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.TaskState));



    }

}
