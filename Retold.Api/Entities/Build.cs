namespace Retold.Api.Entities
{
	public class Build : EntityBase
	{
		public string Name { get; set; } = default!;
        public int PantheonId { get; set; }
        public int MajorGodId { get; set; }
        public int CategoryId { get; set; }
		public string UserId { get; set; } = default!;
		public string? Version { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }


		public List<Step> Steps { get; set; } = default!;
        public List<BuildTag> Tags { get; set; } = default!;
        public List<Like> Likes { get; set; } = default!;
        public List<Video> Videos { get; set; } = default!;
        public Category Category { get; set; } = default!;
        public MajorGod MajorGod { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}
