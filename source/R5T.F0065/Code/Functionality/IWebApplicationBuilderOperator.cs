using System;

using Microsoft.AspNetCore.Builder;

using R5T.T0132;


namespace R5T.F0065
{
	[FunctionalityMarker]
	public partial interface IWebApplicationBuilderOperator : IFunctionalityMarker
	{
		public WebApplicationBuilder New()
		{
			var webApplicationBuilder = WebApplication.CreateBuilder();
			return webApplicationBuilder;
		}
	}
}