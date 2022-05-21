using Microsoft.OpenApi.Models;

namespace MyFirstWebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static ServiceCollection AddSwaggerBasicInfo(this ServiceCollection services)
        {
            services.AddSwaggerGen(options =>
           {
               options.SwaggerDoc("v1", new OpenApiInfo
               {
                   Version = "v1",
                   Title = "Rajesh Web API",
                   Description = "An ASP.NET Core Web API for testing all core functionalities",
                   TermsOfService = new Uri("https://example.com/terms"),
                   Contact = new OpenApiContact
                   {
                       Name = "Example Contract",
                       Url = new Uri("https://example.come/contact")
                   },
                   License = new OpenApiLicense
                   {
                       Name = "Example License",
                       Url = new Uri("https://example.com/license")
                   }
               });
           });

            return services;
        }
    }
}

