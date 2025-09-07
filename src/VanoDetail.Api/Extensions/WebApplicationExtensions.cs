using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using VanoDetail.Storage.Context;

namespace VanoDetail.Api.Extensions;

public static class WebApplicationExtensions
{
    public static async Task DbMigrate(this WebApplication webApplication)
    {
        var scope = webApplication.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<VanoDetailContext>().Database;

        if (db.HasPendingModelChanges())
        {
            await db.MigrateAsync();
        }
    }
}
