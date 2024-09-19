using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Requests.Pantheon;
using Retold.Api.Dtos.Responses.Pantheon;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;
using Retold.Api.Services.Interfaces;

namespace Retold.Api.Services
{
	public class PantheonService : IPantheonService
	{
		private readonly IPantheonRepository pantheonRepository;
		private readonly IMapper mapper;

		public PantheonService(IPantheonRepository pantheonRepository, IMapper mapper)
		{
			this.pantheonRepository = pantheonRepository;
			this.mapper = mapper;
		}

		public async Task<IEnumerable<PantheonResponse>> Get()
		{
			var pantheons = await pantheonRepository.GetAll();
			return mapper.Map<IEnumerable<PantheonResponse>>(pantheons);
		}
		public async Task<PantheonResponse> Get(int id)
		{
			return null;
		}
		public async Task<PantheonResponse> Store(StorePantheonRequest request)
		{
			var pantheon = mapper.Map<Pantheon>(request);
			pantheon = await pantheonRepository.Create(pantheon);
			return mapper.Map<PantheonResponse>(pantheon);
		}
		public Task<PantheonResponse> Update(int id, UpdatePantheonRequest request)
		{
			return null;
		}
		public Task Destroy(int id)
		{
			return Task.Run(() => { });
		}
	}
}
