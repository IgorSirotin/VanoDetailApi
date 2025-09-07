using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VanoDetail.Domain;

namespace VanoDetail.Storage.Context;
public class VanoDetailContext(DbContextOptions<VanoDetailContext> options) : DbContext(options)
{
    public DbSet<ServiceEntity> Services { get; set; }

    public DbSet<AppointmentEntity> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
} 
