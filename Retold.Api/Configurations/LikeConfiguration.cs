using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class LikeConfiguration : EntityTypeBaseConfiguration<Like>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Like> builder)
		{
			builder.HasOne(like => like.User).WithMany(user => user.Likes);
			builder.HasOne(like => like.Build).WithMany(build => build.Likes);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Like> builder)
		{
			builder.Property(like => like.Id).IsRequired();
			builder.Property(like => like.UserId).IsRequired();
			builder.Property(like => like.Date).HasColumnType("DateTime").IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Like> builder)
		{
			builder.ToTable(nameof(Like) + "s");
		}
	}
}
