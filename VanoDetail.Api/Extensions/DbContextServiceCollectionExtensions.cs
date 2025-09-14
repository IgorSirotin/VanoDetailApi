using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace VanoDetail.Api.Extensions;

/// <summary>
/// Методы расширения для <see cref="IServiceCollection"/>. Работа с контекстом БД.
/// </summary>
public static class DbContextServiceCollectionExtensions
{
    /// <summary>
    /// Добавление контекста базы данных приложения.
    /// </summary>
    /// <param name="services">Коллекция сервисов.</param>
    /// <param name="connection">Строка подключения к БД.</param>
    /// <typeparam name="TContext">Тип контекста БД.</typeparam>
    /// <returns>Та же коллекция сервисов для цепочечного вызова.</returns>
    public static IServiceCollection AddDbContext<TContext>(
        this IServiceCollection services,
        string connection)
        where TContext : DbContext =>
        services.AddDbContext<TContext>(options =>
            options.UseNpgsql(connection,
            b => b.MigrationsAssembly("VanoDetail.Migrations")));
}
