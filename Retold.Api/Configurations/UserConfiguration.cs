using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class UserConfiguration : EntityTypeBaseConfiguration<User>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<User> builder)
		{
			builder.HasMany(user => user.Likes).WithOne(like => like.User).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(user => user.Builds).WithOne(build => build.User);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<User> builder)
		{

		}

		protected override void ConfigurateTableName(EntityTypeBuilder<User> builder)
		{
			builder.ToTable(nameof(User) + "s");
		}
	}
}
