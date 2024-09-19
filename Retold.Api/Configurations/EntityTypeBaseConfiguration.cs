using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GimnasioApi.Configurations
{
	public abstract class EntityTypeBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			ConfigurateProperties(builder);
			ConfigurateConstrains(builder);
			ConfigurateTableName(builder);
		}
		protected abstract void ConfigurateTableName(EntityTypeBuilder<T> builder);
		protected abstract void ConfigurateConstrains(EntityTypeBuilder<T> builder);
		protected abstract void ConfigurateProperties(EntityTypeBuilder<T> builder);
	}
}
