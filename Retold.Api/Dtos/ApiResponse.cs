namespace Retold.Api.Dtos
{
	public class ApiResponse<T> : BaseApiResponse
	{
        public T data { get; set; }
    }
}
