using DiecastHub.DTO.Person.Request;
using DiecastHub.DTO.Person.Response;
using DiecastHub.Models;
using DiecastHub.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiecastHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonServices _service;
        public PersonController(IPersonServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonResponseDTO>>> GetPersonsList() => Ok(await _service.GetAllPersonsAsync());

        [HttpGet("{PersonId}")]
        public async Task<ActionResult<PersonResponseDTO>> GetPersonById(int PersonId)
        {
            var person = await _service.GetPersonByIdAsync(PersonId);

            return person is null ? NotFound($"No person with id {PersonId} found.") : Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult<PersonResponseDTO>> AddPerson(PersonCreateDTO person)
        {
            var createdPerson = await _service.AddPersonAsync(person);
            return CreatedAtAction(nameof(GetPersonById), new { PersonId = createdPerson.PersonId }, createdPerson);
        }

        [HttpPut("{PersonId}")]
        public async Task<ActionResult> UpdatePerson(int PersonId, PersonUpdateDTO person)
        {
            var result = await _service.UpdatePersonAsync(PersonId, person);
            return result ? NoContent() : NotFound($"No person with id {PersonId} found.");
        }

    }
}
