using System;
using AutoMapper;
using Crea_Demo.Domain;

namespace Crea_Demo.Infrastructure
{
	public class PersonProfile : Profile
	{
		public PersonProfile()
		{
			CreateMap<Person, PersonDTO>();
			CreateMap<PersonDTO, Person>();

		}
	}
}

