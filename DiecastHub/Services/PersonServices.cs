using DiecastHub.Data;
using DiecastHub.DTO.Person.Request;
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
        
        public async Task<List<PersonResponseDTO>> GetAllPersonsAsync() => 
            await _context.Person.Select(q => new PersonResponseDTO
            {
                PersonId = q.PersonId,
                FirstName = q.FirstName,
                LastName = q.LastName,
                MiddleName = q.MiddleName,
                BirthDate = q.BirthDate
            }).ToListAsync();

        public async Task<PersonResponseDTO?> GetPersonByIdAsync(int id) => await _context.Person
        .Where(q => q.PersonId == id)    
        .Select(q => new PersonResponseDTO 
        {
            PersonId = q.PersonId,
            FirstName = q.FirstName,
            LastName = q.LastName,
            MiddleName = q.MiddleName,
            BirthDate = q.BirthDate
        }).FirstOrDefaultAsync();
        public async Task<PersonResponseDTO> AddPersonAsync(PersonCreateDTO person)
        {
            var newPerson = new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                BirthDate = person.BirthDate
            };

            _context.Person.Add(newPerson);
            await _context.SaveChangesAsync();

            return new PersonResponseDTO
            {
                PersonId = newPerson.PersonId,
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                MiddleName = newPerson.MiddleName,
                BirthDate = newPerson.BirthDate
            };
        }
        public async Task<bool> DeletePersonAsync(int id)
        {
            throw new NotImplementedException();
        }
         
        public async Task<bool> UpdatePersonAsync(int id, PersonUpdateDTO person)
        {
            var existingPerson = _context.Person.Find(id);
            if (existingPerson == null) return false;

            existingPerson.FirstName = person.FirstName;
            existingPerson.LastName = person.LastName;
            existingPerson.MiddleName = person.MiddleName;
            existingPerson.BirthDate = person.BirthDate;

            return true;
        }

    
    }
}
