using DiecastHub.Data;
using DiecastHub.DTO.User.Request;
using DiecastHub.DTO.User.Response;
using DiecastHub.Models;
using DiecastHub.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DiecastHub.Services
{
    public class UserServices : IUserServices
    {
        private readonly ApplicationDbContext _context;

        public UserServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserResponseDTO> AddUserAsync(UserCreateDTO user)
        {
            var hasher = new PasswordHasher<User>();

            var newUserEntity = new User
            {
                Username = user.Username,
                IsActive = true
            };

            newUserEntity.Password = hasher.HashPassword(newUserEntity, user.Password);

            _context.User.Add(newUserEntity);
            await _context.SaveChangesAsync();

            return new UserResponseDTO
            {
                UserId = newUserEntity.UserId,
                Username = newUserEntity.Username,
                IsActive = newUserEntity.IsActive
            };
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserResponseDTO>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<UserResponseDTO?> GetUserAByIdAsync(int id) => await _context.User
        .Where(q => q.UserId == id)
        .Select(q => new UserResponseDTO
        {
            Username = q.Username,
            IsActive = q.IsActive
        }).FirstOrDefaultAsync();

        public Task<bool> UpdateUserAsync(int id, UserUpdateDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
