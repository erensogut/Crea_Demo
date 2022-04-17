using System;
namespace Crea_Demo.Domain
{
	public class CommunityWithPersonDTO
	{
		
		public int CommunityId { get; set; }
		public string CommunityName { get; set; }
		public List<Person> Person { get; set; }
	}
}

