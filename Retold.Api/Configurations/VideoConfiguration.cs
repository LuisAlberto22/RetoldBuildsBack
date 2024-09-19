using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class VideoConfiguration : EntityTypeBaseConfiguration<Video>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Video> builder)
		{
			builder.HasOne(like => like.Build).WithMany(build => build.Videos);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Video> builder)
		{
			builder.Property(video => video.Id).IsRequired();
			builder.Property(video => video.BuildId).IsRequired();
			builder.Property(video => video.Link).HasMaxLength(200).IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Video> builder)
		{
			builder.ToTable(nameof(Video) + "s");
		}
	}
}
