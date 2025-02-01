using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskCaseController : ControllerBase
    {
        private readonly CreateTaskCaseService _createTaskCase;
        private readonly GetByCaseTaskCaseService _getByCase;

        public TaskCaseController(CreateTaskCaseService createTaskCase, GetByCaseTaskCaseService getByCase)
        {
            _createTaskCase = createTaskCase;
            _getByCase = getByCase;
        }

        [HttpPost]
        public async Task<ActionResult> Create(TaskCaseCreateDto taskCase)
        {

            var create = await _createTaskCase.Create(taskCase);
            return Ok(create);
        }
        [HttpGet("{caseId}")]
        public async Task<ActionResult> GetAll(int caseId)
        {
            var listAll = await _getByCase.GetByCase(caseId);
            return Ok(listAll);
        }
    }
}
