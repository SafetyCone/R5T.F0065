using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;


public static class WebApplicationExtensions
{
    public static WebApplication ConfigureWebApplication(this WebApplication webApplication,
        Action<WebApplication> webApplicationAction)
    {
        webApplicationAction(webApplication);

        return webApplication;
    }

    public static async Task<WebApplication> ConfigureWebApplication(this Task<WebApplication> gettingWebApplication,
        Action<WebApplication> webApplicationAction)
    {
        var webApplication = await gettingWebApplication;

        webApplication = webApplication.ConfigureWebApplication(webApplicationAction);

        return webApplication;
    }

    public static async Task<WebApplication> ConfigureWebApplication(this WebApplication webApplication,
        Func<WebApplication, Task> webApplicationAction)
    {
        await webApplicationAction(webApplication);

        return webApplication;
    }

    public static async Task<WebApplication> ConfigureWebApplication(this Task<WebApplication> gettingWebApplication,
        Func<WebApplication, Task> webApplicationAction)
    {
        var webApplication = await gettingWebApplication;

        webApplication = await webApplication.ConfigureWebApplication(webApplicationAction);

        return webApplication;
    }

    public static async Task Run(this Task<WebApplication> gettingWebApplication)
    {
        var webApplication = await gettingWebApplication;

        webApplication.Run();
    }

    public static async Task RunAsync(this Task<WebApplication> gettingWebApplication)
    {
        var webApplication = await gettingWebApplication;

        await webApplication.RunAsync();
    }
}

