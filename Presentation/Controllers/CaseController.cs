using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private readonly CreateCaseService _createCaseService;

        public CaseController(CreateCaseService createCaseService)
        {
            _createCaseService = createCaseService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(CaseCreateDto caseCreateDto){

            var create= await _createCaseService.Create(caseCreateDto);
            return Ok(create);
        }
    }
}
