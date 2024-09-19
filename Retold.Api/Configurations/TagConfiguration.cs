using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class TagConfiguration : EntityTypeBaseConfiguration<Tag>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Tag> builder)
		{
			builder.HasMany((tag) => tag.Builds ).WithOne(build => build.Tag);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Tag> builder)
		{
			builder.Property(tag => tag.Id).IsRequired();
			builder.Property(tag => tag.Name).HasMaxLength(125).IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Tag> builder)
		{
			builder.ToTable(nameof(Tag) + "s");
		}
	}
}
