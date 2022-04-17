using System;
using Crea_Demo.Domain;
using Microsoft.EntityFrameworkCore;

namespace Crea_Demo.Infrastructure.Repository
{
	public class CommunityRepository : ICommunityRepository
	{

		private CreaDemoContext context;

		public CommunityRepository(CreaDemoContext context)
		{
			this.context = context;
		}
		public void Create(Community community)
		{
			context.Communities.Add(community);
			context.SaveChangesAsync();

		}
		public void Edit(Community community)
		{
			var entity = context.Communities.Find(community.CommunityId);
			if (entity == null)
			{
				return;
			}

			context.Entry(entity).CurrentValues.SetValues(community);
			context.SaveChangesAsync();
		}
		public void Delete(int id)
		{
			var community = context.Communities.Find(id);
			context.Communities.Remove(community);
			context.SaveChangesAsync();
		}

		public IEnumerable<Community> GetAllCommunity()
		{
			return context.Communities;
		}

		public CommunityWithPersonDTO GetCommunityWithPerson(int id)
		{
			var queryPersonList =
			   from c in context.Communities
			   join e in context.Enrolments on c.CommunityId equals e.CommunityId
			   join p in context.Persons on e.PersonId equals p.PersonId
			   where c.CommunityId == id
			   select p;
			var community = context.Communities.Where(x => x.CommunityId == id).FirstOrDefault();
			var personList = queryPersonList.ToList();
			return new CommunityWithPersonDTO { CommunityId = community.CommunityId,CommunityName=community.CommunityName,Person= personList };
		}
		
		public void AddPersonToCommunity(Enrolment enrolment)
        {
			context.Enrolments.Add(enrolment);
			context.SaveChanges();
		}
		public void DeletePersonToCommunity(Enrolment enrolment)
		{
			context.Enrolments.Remove(enrolment);
			context.SaveChanges();
		}
	}
}

