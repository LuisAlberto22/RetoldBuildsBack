namespace Retold.Api.Dtos.Responses
{
	public class BuildResponse
	{
        public int Id { get; set; }
        public string Name { get; set; } = default!;
		public int PantheonId { get; set; }
		public int MajorGodId { get; set; }
		public int CategoryId { get; set; }
		public string UserId { get; set; } = default!;
		public string? Version { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
