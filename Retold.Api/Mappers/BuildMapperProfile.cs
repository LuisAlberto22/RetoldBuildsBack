using AutoMapper;
using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Responses;
using Retold.Api.Entities;

namespace Retold.Api.Mappers
{
	public class BuildMapperProfile : Profile
	{
		public BuildMapperProfile() 
		{
			CreateMap<Build,BuildResponse>();
			CreateMap<StoreBuildRequest,Build>();
			CreateMap<UpdateBuildRequest,Build>();
		}
	}
}
