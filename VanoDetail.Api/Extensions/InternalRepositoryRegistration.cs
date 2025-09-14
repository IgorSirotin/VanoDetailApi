using Microsoft.Extensions.DependencyInjection;
using VanoDetail.Application.StorageInterfaces;
using VanoDetail.Storage.Repositories;

namespace VanoDetail.Api.Extensions;
public static class InternalRepositoryRegistration
{
    public static IServiceCollection RepositoryRegistration(this IServiceCollection services)
    {
        services.AddScoped<IServiceRepository, ServiceRepository>();

        return services;
    }
}
