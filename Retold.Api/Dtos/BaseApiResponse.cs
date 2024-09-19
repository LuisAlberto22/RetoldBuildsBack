namespace Retold.Api.Dtos
{
	public class BaseApiResponse
	{
        public int Code { get; set; }
		public bool IsSuccess { get; set; } = true;
	}
}