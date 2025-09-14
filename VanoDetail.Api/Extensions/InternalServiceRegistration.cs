using Microsoft.Extensions.DependencyInjection;
using VanoDetail.Application.Services;

namespace VanoDetail.Api.Extensions;
public static class InternalServiceRegistration
{
    public static IServiceCollection ServiceRegistration(this IServiceCollection services)
    {
        services.AddScoped<IServiceService, ServiceService>();

        return services;
    }
}
