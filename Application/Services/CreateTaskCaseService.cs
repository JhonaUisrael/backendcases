using AutoMapper;
using Domain;

namespace Application;

public class CreateTaskCaseService
{
    private readonly ITaskCaseRepository _taskCaseRepository;
    private readonly IMapper _mapper;

    public CreateTaskCaseService(ITaskCaseRepository taskCaseRepository, IMapper mapper)
    {
        _taskCaseRepository = taskCaseRepository;
        _mapper = mapper;
    }

    public async Task<RespuestaModel> Create(TaskCaseCreateDto dto)
    {

        var created = await _taskCaseRepository.CreateSync(_mapper.Map<TaskCase>(dto));

        return new RespuestaModel("Ok", true, created, string.Empty);
    }
}
