using Microsoft.AspNetCore.Mvc.Versioning;

namespace RealStateWebDotNet7Api.Services.WebApi.Versioning
{
    public static class VersioningExtensions
    {

        public static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(o =>
            {
                o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.ReportApiVersions = true;
                //o.ApiVersionReader = new QueryStringApiVersionReader("vapi");
                //o.ApiVersionReader = new HeaderApiVersionReader("vapi");
                o.ApiVersionReader = new UrlSegmentApiVersionReader();


            });

            services.AddVersionedApiExplorer(o => {
                o.GroupNameFormat = "'v'VVV";
                //Needed when urlSegmentApiVersion Reader is implemented
                o.SubstituteApiVersionInUrl = true;
           } );
            return services;
        }

    }
}
