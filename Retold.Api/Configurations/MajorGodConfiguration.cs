using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class MajorGodConfiguration : EntityTypeBaseConfiguration<MajorGod>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<MajorGod> builder)
		{
			builder.HasMany(god => god.Builds).WithOne(build => build.MajorGod);
			builder.HasOne(god => god.Pantheon).WithMany(pantheon => pantheon.MajorGods);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<MajorGod> builder)
		{
			builder.Property(majorGod => majorGod.Id).IsRequired();
			builder.Property(majorGod => majorGod.Name).HasMaxLength(30).IsRequired();
			builder.Property(majorGod => majorGod.PantheonId).IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<MajorGod> builder)
		{
			builder.ToTable(nameof(MajorGod) + "s");
		}
	}
}
