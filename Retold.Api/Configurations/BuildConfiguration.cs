using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class BuildConfiguration : EntityTypeBaseConfiguration<Build>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Build> builder)
		{
			builder.HasMany(build => build.Steps).WithOne(step => step.Build);
			builder.HasOne(build => build.MajorGod).WithMany(majorGod => majorGod.Builds);
			builder.HasOne(build => build.User).WithMany(user => user.Builds);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Build> builder)
		{
			builder.Property(build => build.Id).IsRequired();
			builder.Property(build => build.Name).HasMaxLength(200).IsRequired();
			builder.Property(build => build.PantheonId).IsRequired();
			builder.Property(build => build.MajorGodId).IsRequired();
			builder.Property(build => build.UserId).IsRequired();
			builder.Property(build => build.CreatedAt).HasColumnType("Datetime").IsRequired();
			builder.Property(build => build.UpdatedAt).HasColumnType("Datetime").IsRequired(false);
			builder.Property(build => build.Version).HasMaxLength(10).IsRequired(false);
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Build> builder)
		{
			builder.ToTable(nameof(Build) + "s");
		}
	}
}
