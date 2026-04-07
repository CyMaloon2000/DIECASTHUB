using DiecastHub.Models;
using DiecastHub.Services.IServices;

namespace DiecastHub.Services
{
    public class GenericServices : IGenericServices
    {
        public Task<Person> CreateAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
