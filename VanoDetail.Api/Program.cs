using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VanoDetail.Api.Extensions;
using VanoDetail.Storage.Context;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:Default");

builder.Services
    .ServiceRegistration()
    .RepositoryRegistration()
    .AddDbContext<VanoDetailContext>(connectionString)
    .AddControllers();

var app = builder.Build();
await app.DbMigrate();

app.UseAuthorization();

app.MapControllers();

app.Run();
