using Retold.Api.Repositories;
using Retold.Api.Services.Interfaces;
using System.Reflection;

namespace Retold.Api.Services
{
	public static class ServiceInstaller
	{
		public static void AddServices(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<IBuildService, BuildService>();
			serviceCollection.AddTransient<IPantheonService, PantheonService>();
		}
	}
}
