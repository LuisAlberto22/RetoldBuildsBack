using AutoMapper;
using System.Reflection;

namespace Retold.Api.Mappers
{
	public static class MapperInstaller
	{
		public static void AddProfiles(this IServiceCollection serviceCollection)
		{
			var profiles = Assembly.GetExecutingAssembly()
														.GetTypes()
														.Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsClass)
														.ToList();


			serviceCollection.AddAutoMapper(configuration =>
			{
				foreach (var profile in profiles)
				{
					configuration.AddProfile((Profile)Activator.CreateInstance(profile));
				}
			});
		}
	}
}
