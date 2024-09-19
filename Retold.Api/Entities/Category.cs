namespace Retold.Api.Entities
{
	public class Category : EntityBase
	{
		public string Name { get; set; } = default!;

		public List<Build> Builds { get; set; } = default!;
	}
}
