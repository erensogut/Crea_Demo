using System;
using Crea_Demo.Domain;
using Crea_Demo.Infrastructure;
using Crea_Demo.Infrastructure.Repository;

namespace Crea_Demo.Services
{
	public class PersonService : IPersonService
	{
		
		private readonly PersonRepository _repository;

		public PersonService(PersonRepository repository)
		{
			_repository = repository;

		}

		
		public void CreatePerson(Person person)
		{
			_repository.Create(person);
		}
		
		public void EditPerson(Person person)
		{
			_repository.Edit(person);
		}

		public void DeletePerson(int id)
		{
			_repository.Delete(id);
		}

        public IEnumerable<Person> GetPersonList()
        {
			return _repository.GetAllPerson();
        }
		public IQueryable<Person> SearchPerson(string firstName)
		{
			return _repository.SearchPerson(firstName);
		}
	}
}

