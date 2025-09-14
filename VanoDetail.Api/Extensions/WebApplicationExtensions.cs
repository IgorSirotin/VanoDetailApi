using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using VanoDetail.Storage.Context;

namespace VanoDetail.Api.Extensions;

public static class WebApplicationExtensions
{
    public static async Task DbMigrate(
        this WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateScope();

        var logger = scope.ServiceProvider.GetRequiredService<ILogger<WebApplication>>();
        try
        {

            var dbContext = scope.ServiceProvider.GetRequiredService<VanoDetailContext>();
            logger.LogInformation("Applying migrations...");
            await dbContext.Database.MigrateAsync();
            logger.LogInformation("Migrations applied successfully.");
        }
        catch (Exception ex)
        {
            logger.LogInformation($"Migration error: {ex.Message}");
            logger.LogInformation($"StackTrace: {ex.StackTrace}");
        }
    }
}
