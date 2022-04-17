using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crea_Demo.Domain
{
	public class EnrolmentDTO
	{
        public int EnrolmentId { get; set; }

        public int CommunityId { get; set; }
        public int PersonId { get; set; }

      
    }
}

