using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;

using R5T.T0132;


namespace R5T.F0065
{
	[FunctionalityMarker]
	public partial interface IWebApplicationOperator : IFunctionalityMarker
	{
		public WebApplicationBuilder ConfigureServices(
			Action<IServiceCollection> servicesAction)
		{
			var webApplicationBuilder = Instances.WebApplicationBuilderOperator.New();

			webApplicationBuilder.ConfigureServices(servicesAction);

			return webApplicationBuilder;
		}

		public async Task<WebApplicationBuilder> ConfigureServices(
			Func<IServiceCollection, Task> servicesAction)
		{
			var webApplicationBuilder = Instances.WebApplicationBuilderOperator.New();

			await webApplicationBuilder.ConfigureServices(servicesAction);

			return webApplicationBuilder;
		}

		public WebApplicationBuilder ConfigureWebApplicationBuilder(
			Action<WebApplicationBuilder> webApplicationBuilderAction)
		{
			var webApplicationBuilder = Instances.WebApplicationBuilderOperator.New();

			webApplicationBuilder.ConfigureWebApplicationBuilder(webApplicationBuilderAction);

			return webApplicationBuilder;
		}
	}
}