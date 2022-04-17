using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crea_Demo.Domain
{
	public class Enrolment
	{
        public int EnrolmentId { get; set; }

        [ForeignKey("CommunityId")]
        public int CommunityId { get; set; }
        [ForeignKey("PersonId")]
        public int PersonId { get; set; }

        public virtual Community Community { get; set; }
        public virtual Person Person { get; set; }
    }
}

