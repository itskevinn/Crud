using Domain.Entities;
using Domain.Exceptions;
using Domain.Repository;
using Domain.Services.Base;

namespace Domain.Services
{
    [DomainService]
    public class PersonService
    {
        private readonly IGenericRepository<Person> _repository;

        public PersonService(IGenericRepository<Person> repository)
        {
            _repository = repository;
        }

        public async Task<Person> AddPerson(Person person)
        {
            try
            {
                if (person.Age < 18)
                {
                    throw new UnderAgeException("Persona menor de edad");
                }
                await _repository.AddAsync(person);
                return person;
            }
            catch (Exception)
            {
                throw new AppException();
            }
        }
        public Task<Person> GetById(Guid person)
        {
            return _repository.GetByIdAsync(person);
        }
        public Task<IEnumerable<Person>> GetAllAsync(){
            return _repository.GetAllAsync();
}

    }
}
