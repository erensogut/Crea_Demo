using System;
namespace Crea_Demo.Domain
{
	public class Person
	{
		
		public int PersonId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string  Occupation { get; set; }
		public virtual ICollection<Enrolment> Enrolments { get; set; }

	}
}

