using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class StepConfiguration : EntityTypeBaseConfiguration<Step>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Step> builder)
		{
			builder.HasOne(step => step.Build).WithMany(step => step.Steps);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Step> builder)
		{
			builder.Property(step => step.Id).IsRequired();
			builder.Property(step => step.BuildId).IsRequired();
			builder.Property(step => step.Minute).IsRequired();
			builder.Property(step => step.Description).HasMaxLength(500).IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Step> builder)
		{
			builder.ToTable(nameof(Step) + "s");
		}
	}
}
