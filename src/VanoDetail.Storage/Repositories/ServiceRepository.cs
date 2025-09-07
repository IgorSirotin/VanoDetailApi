using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using VanoDetail.Application.StorageInterfaces;
using VanoDetail.Domain;
using VanoDetail.Storage.Context;

namespace VanoDetail.Storage.Repositories;
public class ServiceRepository(VanoDetailContext context) : IServiceRepository
{
    /// <inheritdoc/>
    public async Task<ServiceEntity?> GetServiceByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.Services.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}

