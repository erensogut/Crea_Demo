using System;
using Crea_Demo.Domain;

namespace Crea_Demo.Services
{
	public interface ICommunityService
	{

		public IEnumerable<Community> GetCommunityList();

		public CommunityWithPersonDTO GetCommunityWithPerson(int id);

		public void CreateCommunity(Community person);

		public void EditCommunity(Community person);

		public void DeleteCommunity(int id);

		public void AddPersonToCommunity(Enrolment enrolment);

		public void DeletePersonToCommunity(Enrolment enrolment);

	}
}

