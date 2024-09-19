using AutoMapper;
using Retold.Api.Repositories.Interfaces;
using System.Reflection;

namespace Retold.Api.Repositories
{
	public static class RepositoriesInstaller
	{
		public static void AddRepositories(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<IBuildRepository,EntityFrameworkBuildRepository>();
			serviceCollection.AddTransient<IPantheonRepository,EntityFrameworkPantheonRepository>();
		}
	}
}
