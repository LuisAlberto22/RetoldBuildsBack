using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Responses;

namespace Retold.Api.Services.Interfaces
{
	public interface IBuildService
	{
		Task Destroy(int id);
		Task<List<BuildResponse>> Get();
		Task<BuildResponse> Get(int id);
		Task<BuildResponse> Store(StoreBuildRequest request);
		Task<BuildResponse> Update(int id, UpdateBuildRequest request);
	}
}