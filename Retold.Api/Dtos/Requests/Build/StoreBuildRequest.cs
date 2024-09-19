namespace Retold.Api.Dtos.Requests
{
	public class StoreBuildRequest
	{
		public string Name { get; set; }
		public int PantheonId { get; set; }
		public int MajorGodId { get; set; }
		public int CategoryId { get; set; }
		public string UserId { get; set; }
		public string? Version { get; set; }
	}
}
