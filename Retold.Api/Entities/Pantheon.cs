namespace Retold.Api.Entities
{
	public class Pantheon : EntityBase
	{
		public string Name { get; set; } = default!;
		public List<MajorGod> MajorGods { get; set; } = default!;
    }
}
