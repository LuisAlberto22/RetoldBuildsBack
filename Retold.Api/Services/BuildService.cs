using AutoMapper;
using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Responses;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;
using Retold.Api.Services.Interfaces;

namespace Retold.Api.Services
{
	public class BuildService : IBuildService
	{
		private readonly IBuildRepository buildRepository;
		private readonly IMapper mapper;

		public BuildService(IBuildRepository buildRepository, IMapper mapper)
		{
			this.buildRepository = buildRepository;
			this.mapper = mapper;
		}

		public async Task<List<BuildResponse>> Get()
		{
			var builds = await buildRepository.GetAll();
			return mapper.Map<List<BuildResponse>>(builds);
		}

		public async Task<BuildResponse> Get(int id)
		{
			var builds = await buildRepository.GetById(id);
			return mapper.Map<BuildResponse>(builds);
		}


		public async Task<BuildResponse> Store(StoreBuildRequest request)
		{
			var build = mapper.Map<Build>(request);
			await buildRepository.Create(build);
			return mapper.Map<BuildResponse>(build);
		}

		public async Task<BuildResponse> Update(int id, UpdateBuildRequest request)
		{
			var build = await buildRepository.GetById(id);
			build = mapper.Map(request, build);
			await buildRepository.Update(build);
			return mapper.Map<BuildResponse>(build);
		}

		public async Task Destroy(int id)
		{
			await buildRepository.Delete(id);
		}

	}
}
