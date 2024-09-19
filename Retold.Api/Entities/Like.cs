namespace Retold.Api.Entities
{
	public class Like : EntityBase
	{
		public string UserId { get; set; } = default!;
		public int BuildID { get; set; }
		public DateTime Date { get; set; }

		public User? User { get; set; } = default!;
		public Build Build { get; set; } = default!;
	}
}
