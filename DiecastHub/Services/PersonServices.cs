using DiecastHub.Models;
using DiecastHub.Services.IServices;

namespace DiecastHub.Services
{
    public class PersonServices : IPersonServices
    {
        static List<Person> persons = new List<Person>
        {
            new Person { PersonId = 1, FirstName = "John", Lastname = "Doe", MiddleName = "A.", BirthDate = new DateTime(1990, 1, 1) },
            new Person { PersonId = 2, FirstName = "Jane", Lastname = "Smith", MiddleName = "B.", BirthDate = new DateTime(1992, 2, 2) },
            new Person { PersonId = 3, FirstName = "Cybe,", Lastname = "Johnson", MiddleName = "C.", BirthDate = new DateTime(1994, 3, 3) }
        };

        public async Task<Person> CreatePersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePersonAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Person>> GetAllPersonsAsync() => await Task.FromResult(persons);

        public async Task<Person?> GetPersonByIdAsync(int id) => await Task.FromResult(persons.FirstOrDefault(p => p.PersonId == id));

        public async Task<Person> UpdatePersonAsync(int id, Person person)
        {
            throw new NotImplementedException();
        }

        Task<bool> IPersonServices.UpdatePersonAsync(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
