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
        private readonly GetAllCasesService _getAllCasesService;

        public CaseController(CreateCaseService createCaseService,
        GetAllCasesService getAllCasesService)
        {
            _createCaseService = createCaseService;
           _getAllCasesService = getAllCasesService;
        }

        [HttpPost]
        public async Task<ActionResult> Create(CaseCreateDto caseCreateDto){

            var create= await _createCaseService.Create(caseCreateDto);
            return Ok(create);
        }
        
        [HttpGet]
         public async Task<ActionResult> GetAll(){

            var listAll= await _getAllCasesService.GetAll();
            return Ok(listAll);
        }
        

    }
}
