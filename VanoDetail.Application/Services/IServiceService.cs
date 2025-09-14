using System.Threading;
using System.Threading.Tasks;
using VanoDetail.Domain;

namespace VanoDetail.Application.Services;

/// <summary>
/// Интерфейс сервиса для получения информации о ресурсах.
/// </summary>
public interface IServiceService
{
    /// <summary>
    /// Получить услугу по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор услуги.</param>
    /// <param name="cancellationToken">Токен отмены.</param>
    /// <returns>Услуга.</returns>
    Task<ServiceEntity> GetServiceByIdAsync(int id, CancellationToken cancellationToken);
}
