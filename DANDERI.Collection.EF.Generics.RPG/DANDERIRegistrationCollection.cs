using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DANDERI.Collection.EF.Generics.RPG
{
	public static class DANDERIRegistrationCollection
	{
		public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration, string Conneting)
		{
			
			
				services.AddDbContext<ApplicationContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DanderiConnection"),
				m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
			
		
		}
}    }
