namespace Retold.Api.Entities
{
	public class BuildTag : EntityBase
	{
        public int BuildId { get; set; }
		public int TagId { get; set; }

        public Tag Tag { get; set; } = default!;
		public Build Build { get; set; } = default!;
    }
}
