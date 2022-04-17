using System;
using Crea_Demo.Domain;

namespace Crea_Demo.Infrastructure.Repository
{
	public interface ICommunityRepository
	{
		public void Create(Community community);

		public void Edit(Community community);

		public void Delete(int id);

		public IEnumerable<Community> GetAllCommunity();

		public CommunityWithPersonDTO GetCommunityWithPerson(int id);

		public void AddPersonToCommunity(Enrolment enrolment);

		public void DeletePersonToCommunity(Enrolment enrolment);

	}
}

