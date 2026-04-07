using DiecastHub.Models;

namespace DiecastHub.Services.IServices
{
    public interface IGenericServices 
    {
        Task<List<Person>> GetAllAsync();
        Task<Person?> GetByIdAsync(int id);
        Task<Person> CreateAsync(Person person);
        Task<bool> UpdateAsync(int id, Person person);
        Task<bool> DeleteAsync(int id);
    }
}
