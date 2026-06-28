using DiecastHub.DTO.User.Request;
using DiecastHub.DTO.User.Response;
using DiecastHub.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace DiecastHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _services;

        public UserController(IUserServices services)
        {
            _services = services;
        }

        [HttpGet("{UserId}")]
        public async Task<ActionResult<UserResponseDTO>> GetUserById(int UserId)
        {
            var user = await _services.GetUserAByIdAsync(UserId);

            return user is null
                ? NotFound($"No user with the id {UserId} found.")
                : Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserResponseDTO>> AddUser(UserCreateDTO user)
        {
            var createdUser = await _services.AddUserAsync(user);

            return CreatedAtAction(nameof(GetUserById),
                new { UserId = createdUser.UserId },
                createdUser);
        }
    }
}
