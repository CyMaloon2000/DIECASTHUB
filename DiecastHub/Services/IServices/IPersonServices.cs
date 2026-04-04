using DiecastHub.Models;

namespace DiecastHub.Services.IServices
{
    public interface IPersonServices
    {
        Task<List<Person>> GetAllPersonsAsync();
        Task<Person?> GetPersonByIdAsync(int id);
        Task<Person> CreatePersonAsync(Person person);
        Task<bool> UpdatePersonAsync(int id, Person person);
        Task<bool> DeletePersonAsync(int id);
    }
}
