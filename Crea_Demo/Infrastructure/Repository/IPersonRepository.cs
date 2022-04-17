using System;
using Crea_Demo.Domain;

namespace Crea_Demo.Infrastructure.Repository
{
	public interface IPersonRepository
	{
		public void Create(Person person);


		public void Edit(Person person);


		public void Delete(int id);

		public IEnumerable<Person> GetAllPerson();

		public IQueryable<Person> SearchPerson(string firstName);

	}
}

