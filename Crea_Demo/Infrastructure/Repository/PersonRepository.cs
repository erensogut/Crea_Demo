using System;
using Crea_Demo.Domain;
using Microsoft.EntityFrameworkCore;

namespace Crea_Demo.Infrastructure.Repository
{
	public class PersonRepository : IPersonRepository
	{
		
		private CreaDemoContext context;

		public PersonRepository(CreaDemoContext context)
		{
			this.context = context;
		}
		public void Create(Person person)
		{
			context.Persons.Add(person);
			context.SaveChangesAsync();

		}
		public void Edit(Person person)
		{
			var entity = context.Persons.Find(person.PersonId);
			if (entity == null)
			{
				return;
			}

			context.Entry(entity).CurrentValues.SetValues(person);
			context.SaveChangesAsync();
		}
		public void Delete(int id)
        {
			var person = context.Persons.Find(id);
			context.Persons.Remove(person);
			context.SaveChangesAsync();
		}

        public IEnumerable<Person> GetAllPerson()
        {
			return context.Persons;
        }
		public IQueryable<Person> SearchPerson(string firstName)
        {
			return context.Persons.Where(x => x.FirstName.ToLower().Contains(firstName.Trim().ToLower()));
        }
    }
}

