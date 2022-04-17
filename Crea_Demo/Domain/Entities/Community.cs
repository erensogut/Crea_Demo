using System;
namespace Crea_Demo.Domain
{
	public class Community
	{
		
		public int CommunityId { get; set; }
		public string CommunityName { get; set; }
		public virtual ICollection<Enrolment> Enrolments { get; set; }

	}
}

