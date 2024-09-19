namespace Retold.Api.Entities
{
	public class Step : EntityBase
	{
		public int BuildId { get; set; }
		public TimeOnly Minute { get; set; }
		public string Description { get; set; } = default!;
		public Build Build { get; set; } = default!;
	}
}
