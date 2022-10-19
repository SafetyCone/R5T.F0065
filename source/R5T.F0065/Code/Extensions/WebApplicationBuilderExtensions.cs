using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;


public static class WebApplicationBuilderExtensions
{
    public static async Task<WebApplication> Build(this Task<WebApplicationBuilder> gettingWebApplicationBuiilder)
    {
        var webApplicationBuilder = await gettingWebApplicationBuiilder;

        var webApplication = webApplicationBuilder.Build();
        return webApplication;
    }

    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder webApplicationBuilder,
        Action<IServiceCollection> servicesAction)
    {
        servicesAction(webApplicationBuilder.Services);

        return webApplicationBuilder;
    }

    public static async Task<WebApplicationBuilder> ConfigureServices(this Task<WebApplicationBuilder> gettingWebApplicationBuilder,
        Action<IServiceCollection> servicesAction)
    {
        var webApplicationBuilder = await gettingWebApplicationBuilder;

        return webApplicationBuilder.ConfigureServices(servicesAction);
    }

    public static async Task<WebApplicationBuilder> ConfigureServices(this WebApplicationBuilder webApplicationBuilder,
        Func<IServiceCollection, Task> servicesAction)
    {
        await servicesAction(webApplicationBuilder.Services);

        return webApplicationBuilder;
    }

    public static async Task<WebApplicationBuilder> ConfigureServices(this Task<WebApplicationBuilder> gettingWebApplicationBuilder,
        Func<IServiceCollection, Task> servicesAction)
    {
        var webApplicationBuilder = await gettingWebApplicationBuilder;

        webApplicationBuilder = await webApplicationBuilder.ConfigureServices(servicesAction);
        
        return webApplicationBuilder;
    }

    public static WebApplicationBuilder ConfigureWebApplicationBuilder(this WebApplicationBuilder webApplicationBuilder,
        Action<WebApplicationBuilder> webApplicationBuilderAction)
    {
        webApplicationBuilderAction(webApplicationBuilder);

        return webApplicationBuilder;
    }

    public static async Task<WebApplicationBuilder> ConfigureWebApplicationBuilder(this Task<WebApplicationBuilder> gettingWebApplicationBuilder,
        Action<WebApplicationBuilder> webApplicationBuilderAction)
    {
        var webApplicationBuilder = await gettingWebApplicationBuilder;

        webApplicationBuilder.ConfigureWebApplicationBuilder(webApplicationBuilderAction);

        return webApplicationBuilder;
    }

    public static async Task<WebApplicationBuilder> ConfigureWebApplicationBuilder(this WebApplicationBuilder webApplicationBuilder,
        Func<WebApplicationBuilder, Task> webApplicationBuilderAction)
    {
        await webApplicationBuilderAction(webApplicationBuilder);

        return webApplicationBuilder;
    }

    public static async Task<WebApplicationBuilder> ConfigureWebApplicationBuilder(this Task<WebApplicationBuilder> gettingWebApplicationBuilder,
        Func<WebApplicationBuilder, Task> webApplicationBuilderAction)
    {
        var webApplicationBuilder = await gettingWebApplicationBuilder;

        await webApplicationBuilder.ConfigureWebApplicationBuilder(webApplicationBuilderAction);

        return webApplicationBuilder;
    }
}

