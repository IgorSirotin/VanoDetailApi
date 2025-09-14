using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VanoDetail.Application.StorageInterfaces;
using VanoDetail.Domain;

namespace VanoDetail.Application.Services;

/// <summary>
/// Сервис для получения информации об услугах.
/// </summary>
public class ServiceService(IServiceRepository serviceRepository) : IServiceService
{
    /// <inheritdoc/>
    public async Task<ServiceEntity> GetServiceByIdAsync(int id, CancellationToken cancellationToken) =>
        await serviceRepository.GetServiceByIdAsync(id, cancellationToken) ??
            throw new KeyNotFoundException($"Услуги с идентификатором {id} не найдено.");
}

