using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VanoDetail.Api.Extensions;
using VanoDetail.Application.Services;
using VanoDetail.Application.StorageInterfaces;
using VanoDetail.Storage.Context;
using VanoDetail.Storage.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<IServiceService, ServiceService>()
    .AddScoped<IServiceRepository, ServiceRepository>()
    .AddDbContext<VanoDetailContext>(builder.Configuration.GetConnectionString("Default"))
    .AddControllers();

var app = builder.Build();

await app.DbMigrate();

app.MapControllers();

app.Run();
