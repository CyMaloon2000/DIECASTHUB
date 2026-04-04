using DiecastHub.Models;
using DiecastHub.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiecastHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController(IPersonServices service) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPersonsList() => Ok(await service.GetAllPersonsAsync());

        [HttpGet("{PersonId}")]
        public async Task<ActionResult<Person>> GetPersonById(int PersonId)
        {
            var person = await service.GetPersonByIdAsync(PersonId);

            return person is null ? NotFound($"No person with id {PersonId} found.") : Ok(person);
        }
    }
}
