using System;
using AutoMapper;
using Crea_Demo.Domain;

namespace Crea_Demo.Infrastructure
{
	public class EnrolmentProfile : Profile
	{
		public EnrolmentProfile()
		{
			CreateMap<Enrolment, EnrolmentDTO>();
			CreateMap<EnrolmentDTO, Enrolment>();

		}
	}
}

