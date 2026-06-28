using DiecastHub.DTO.User.Request;
using DiecastHub.DTO.User.Response;

namespace DiecastHub.Services.IServices
{
    public interface IUserServices
    {
        Task<List<UserResponseDTO>> GetAllUserAsync();
        Task<UserResponseDTO?> GetUserAByIdAsync(int id);
        Task<UserResponseDTO> AddUserAsync(UserCreateDTO user);
        Task<bool> UpdateUserAsync(int id, UserUpdateDTO user);
        Task<bool> DeleteUserAsync(int id);
    }
}
