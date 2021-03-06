using Microsoft.Extensions.DependencyInjection;

namespace AWS.Insurance.Locations.Api.StartupExtensions
{
    public static class HttpContextAcessorz
    {
        public static IServiceCollection ConfigureHttpContextAcessor(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            return services;
        }
    }
}