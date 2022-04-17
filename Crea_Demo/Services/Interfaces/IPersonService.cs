using System;
using Crea_Demo.Domain;

namespace Crea_Demo.Services
{
	public interface IPersonService
	{

		public IEnumerable<Person> GetPersonList();


		public void CreatePerson(Person person);



		public void EditPerson(Person person);



		public void DeletePerson(int id);

		public IQueryable<Person> SearchPerson(string firstName);

	}
}

