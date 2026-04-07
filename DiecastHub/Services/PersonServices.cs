using DiecastHub.Data;
using DiecastHub.DTO.Person.Response;
using DiecastHub.Models;
using DiecastHub.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace DiecastHub.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly ApplicationDbContext _context;
        public PersonServices(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Person> CreatePersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePersonAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PersonResponseDTO>> GetAllPersonsAsync() => 
            await _context.Person.Select(q => new PersonResponseDTO 
            { 
                FirstName = q.FirstName,
                LastName = q.LastName,
                MiddleName = q.MiddleName,
                BirthDate = q.BirthDate
            }).ToListAsync();

        public async Task<PersonResponseDTO?> GetPersonByIdAsync(int id) => await _context.Person
        .Where(q => q.PersonId == id)    
        .Select(q => new PersonResponseDTO 
        {
            FirstName = q.FirstName,
            LastName = q.LastName,
            MiddleName = q.MiddleName,
            BirthDate = q.BirthDate
        }).FirstOrDefaultAsync();

        public async Task<PersonResponseDTO> UpdatePersonAsync(int id, Person person)
        {
            throw new NotImplementedException();
        }

        Task<bool> IPersonServices.UpdatePersonAsync(int id, PersonResponseDTO person)
        {
            throw new NotImplementedException();
        }
    }
}
