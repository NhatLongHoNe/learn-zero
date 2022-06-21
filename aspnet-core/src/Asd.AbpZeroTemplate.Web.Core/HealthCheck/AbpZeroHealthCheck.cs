using Microsoft.Extensions.DependencyInjection;
using Asd.AbpZeroTemplate.HealthChecks;

namespace Asd.AbpZeroTemplate.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<AbpZeroTemplateDbContextHealthCheck>("Database Connection");
            builder.AddCheck<AbpZeroTemplateDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
