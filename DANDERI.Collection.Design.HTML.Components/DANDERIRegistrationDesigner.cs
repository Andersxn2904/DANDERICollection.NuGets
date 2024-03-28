using DANDERI.Collection.Design.HTML.Components.Designer;
using Microsoft.Extensions.DependencyInjection;

namespace DANDERI.Collection.Design.HTML.Components
{
	public static class DANDERIRegistrationDesigner
	{
		
			public static void DanderiAddPersistenceSqlServer<Context>(this IServiceCollection services) 
			{




				#region Register Danderi Designer
				services.AddTransient<IHtmlDesigner, HtmlDesigner>();
				#endregion


			}
		

	}
}
