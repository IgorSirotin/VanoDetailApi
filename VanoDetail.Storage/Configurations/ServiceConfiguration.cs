using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VanoDetail.Domain;

namespace VanoDetail.Storage.Configurations;

/// <summary>
/// Конфигурация для <see cref="ServiceEntity"/>
/// </summary>
public class ServiceConfiguration : IEntityTypeConfiguration<ServiceEntity>
{
    private readonly string _tableName = "service";

    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ServiceEntity> builder)
    {
        builder.ToTable(_tableName);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName($"{_tableName}_id").ValueGeneratedOnAdd();

        builder.Property(x => x.Guid).HasColumnName($"{_tableName}_guid").ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasColumnName("name").IsRequired(true);

        builder
            .HasMany(x => x.Appointments)
            .WithMany(x => x.Services);
    }
}

