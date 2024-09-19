namespace Retold.Api.Entities
{
	public class MajorGod : EntityBase
	{
		public int PantheonId { get; set; }
		public string Name { get; set; } = default!;

		public Pantheon Pantheon { get; set; } = default!;
		public List<Build> Builds { get; set; } = default!;
    }
}
