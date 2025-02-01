using AutoMapper;
using Domain;

namespace Application;

public class GetByCaseTaskCaseService
{
    private readonly ITaskCaseRepository _taskCaseRepository;
    private readonly IMapper _mapper;

    public GetByCaseTaskCaseService(ITaskCaseRepository taskCaseRepository, IMapper mapper)
    {
        _taskCaseRepository = taskCaseRepository;
        _mapper = mapper;
    }

    public async Task<RespuestaModel> GetByCase(int caseId)
    {

        var casetask = await _taskCaseRepository.GetByCaseAsync(caseId);
        return new RespuestaModel("Ok", true, _mapper.Map<TaskCaseViewDto>(casetask), string.Empty);
    }
}
