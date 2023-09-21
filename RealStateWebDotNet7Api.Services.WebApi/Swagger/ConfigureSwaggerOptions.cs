using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RealStateWebDotNet7Api.Services.WebApi.Swagger
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider provider;
        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)  => this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach ( var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }
        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Version = description.ApiVersion.ToString(),
                Title = "API testIntegration INFO",
                Description = "Simple description for this api as test",
                Contact = new OpenApiContact
                {
                    Name ="yonson",
                    Email = "yonson@gmail.com"
                }

            };
            if (description.IsDeprecated)
            {
                info.Description += "this version is Deprecated.";
            }
            return info;
        }
    }
}
