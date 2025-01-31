using AutoMapper;
using Domain;

namespace Application;

public class CreateCaseService
{
    private readonly ICaseRepository _caseRepository;
    private readonly IMapper _mapper;

    public CreateCaseService(ICaseRepository caseRepository, IMapper mapper)
    {
        _caseRepository = caseRepository;
        _mapper = mapper;
    }

    public async Task<RespuestaModel> Create(CaseCreateDto dto)
    {
        var entity = _mapper.Map<Case>(dto);
        return new RespuestaModel("Ok", true, await _caseRepository.CreateSync(entity), string.Empty);
    }
}
