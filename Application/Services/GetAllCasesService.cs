using AutoMapper;
using Domain;

namespace Application;

public class GetAllCasesService
{
    private readonly ICaseRepository _caseRepository;
    private readonly IMapper _mapper;
    public GetAllCasesService(ICaseRepository caseRepository, IMapper mapper)
    {
        _caseRepository = caseRepository;
        _mapper = mapper;
    }

    public async Task<RespuestaModel> GetAll()
    {

        var cases=await _caseRepository.GetAllAsync();
        return new RespuestaModel("Ok",true,_mapper.Map<IEnumerable<CaseViewDto>>(cases),string.Empty);
    }
}
