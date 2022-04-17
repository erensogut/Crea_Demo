using System;
using Crea_Demo.Domain;
using Crea_Demo.Infrastructure;
using Crea_Demo.Infrastructure.Repository;

namespace Crea_Demo.Services
{
	public class CommunityService : ICommunityService
	{
		
		private readonly ICommunityRepository _repository;

		public CommunityService(ICommunityRepository repository)
		{
			_repository = repository;

		}

		
		public void CreateCommunity(Community community)
		{
			_repository.Create(community);
		}
		
		public void EditCommunity(Community community)
		{
			_repository.Edit(community);
		}

		public void DeleteCommunity(int id)
		{
			_repository.Delete(id);
		}

        public IEnumerable<Community> GetCommunityList()
        {
			return _repository.GetAllCommunity();
        }
		public CommunityWithPersonDTO GetCommunityWithPerson(int id)
		{
			return _repository.GetCommunityWithPerson(id);
		}
		
		public void AddPersonToCommunity(Enrolment enrolment)
		{
			_repository.AddPersonToCommunity(enrolment);
		}
		public void DeletePersonToCommunity(Enrolment enrolment)
		{
			_repository.DeletePersonToCommunity(enrolment);
		}
	}
}

