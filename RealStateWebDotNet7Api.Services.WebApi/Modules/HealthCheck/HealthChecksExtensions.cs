namespace RealStateWebDotNet7Api.Services.WebApi.Modules.HealthCheck
{
    public static class HealthChecksExtensions
    {
        public static IServiceCollection AddHealthCheck(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddHealthChecks().AddSqlServer(configuration.GetConnectionString("realstateSqlConnection"), tags: new[] { "database" });
            services.AddHealthChecksUI();
            services.AddHealthChecksUI().AddInMemoryStorage();

            return services;
        }

    }
}
