using AutoMapper;
using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Responses.Pantheon;
using Retold.Api.Entities;

namespace Retold.Api.Mappers
{
	public class PantheonMapperProfile : Profile
	{
		public PantheonMapperProfile()
		{
			CreateMap<StorePantheonRequest, Pantheon>();
			CreateMap<UpdateBuildRequest, Pantheon>();
			CreateMap<Pantheon, PantheonResponse>();
		}
	}
}
