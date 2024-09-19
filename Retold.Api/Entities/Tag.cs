namespace Retold.Api.Entities
{
	public class Tag : EntityBase
	{
        public string Name { get; set; } = default!;

        public List<BuildTag> Builds { get; set; } = default!;
    }
}
