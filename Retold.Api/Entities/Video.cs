namespace Retold.Api.Entities
{
	public class Video : EntityBase
	{
		public string Name { get; set; } = default!;
		public int BuildId { get; set; }
		public string Link { get; set; } = default!;
		public Build Build { get; set; } = default!;
    }
}
