using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DANDERI.Collection.EF.Generics.RPG.Interface;
using DANDERI.Collection.EF.Generics.RPG.Repository;


namespace DANDERI.Collection.EF.Generics.RPG
{
	public static class DANDERIRegistrationCollection
	{
		public static void DanderiAddPersistenceSqlServer<Context>(this IServiceCollection services, string SqlServerConnetionString) where Context : DbContext
		{


			services.AddDbContext<Context>(options =>
		    options.UseSqlServer(SqlServerConnetionString,
		    m => m.MigrationsAssembly(typeof(Context).Assembly.FullName)));

			#region Register Danderi Repository
			services.AddTransient(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
			#endregion


		}
	}
}

