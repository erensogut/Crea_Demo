using System;
using AutoMapper;
using Crea_Demo.Domain;

namespace Crea_Demo.Infrastructure
{
	public class CommunityProfile : Profile
	{
		public CommunityProfile()
		{
			CreateMap<Community, CommunityDTO>();
			CreateMap<CommunityDTO, Community>();

		}
	}
}

