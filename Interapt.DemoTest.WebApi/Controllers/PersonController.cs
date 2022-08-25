using Interapt.DemoTest.BusinessObjects;
using Interapt.DemoTest.WebApi.Business.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Interapt.DemoTest.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetPeople()
        {       
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPerson(int id)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody]Person person)
        {
        }
    }
}