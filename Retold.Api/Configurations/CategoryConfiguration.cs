using GimnasioApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retold.Api.Entities;

namespace Retold.Api.Configurations
{
	public class CategoryConfiguration : EntityTypeBaseConfiguration<Category>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Category> builder)
		{
			builder.HasMany(category => category.Builds).WithOne(build => build.Category);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Category> builder)
		{
			builder.Property(category => category.Id).IsRequired();
			builder.Property(category => category.Name).HasMaxLength(50).IsRequired();
		}

		protected override void ConfigurateTableName(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Categories");
		}
	}
}
