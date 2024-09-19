using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Requests.Pantheon;
using Retold.Api.Dtos.Responses.Pantheon;

namespace Retold.Api.Services.Interfaces
{
	public interface IPantheonService
	{
		Task Destroy(int id);
		Task<IEnumerable<PantheonResponse>> Get();
		Task<PantheonResponse> Get(int id);
		Task<PantheonResponse> Store(StorePantheonRequest request);
		Task<PantheonResponse> Update(int id, UpdatePantheonRequest request);
	}
}