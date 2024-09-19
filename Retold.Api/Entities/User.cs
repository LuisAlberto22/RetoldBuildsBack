using Microsoft.AspNetCore.Identity;

namespace Retold.Api.Entities
{
	public class User : IdentityUser
	{
        public List<Like> Likes { get; set; } = default!;
        public List<Build> Builds { get; set; } = default!;
	}
}
