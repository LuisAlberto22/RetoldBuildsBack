using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class PantheonConfiguration : EntityTypeBaseConfiguration<Pantheon>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Pantheon> builder)
		{
			builder.HasMany(pantheon => pantheon.MajorGods).WithOne(majorGod => majorGod.Pantheon);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Pantheon> builder)
		{
			builder.Property(panthon => panthon.Id).IsRequired();
			builder.Property(panthon => panthon.Name).HasMaxLength(30).IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Pantheon> builder)
		{
			builder.ToTable(nameof(Pantheon) + "s");
		}
	}
}
