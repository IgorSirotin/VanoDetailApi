using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VanoDetail.Domain;

namespace VanoDetail.Storage.Configurations;

public class AppointmentConfiguration : IEntityTypeConfiguration<AppointmentEntity>
{
    private readonly string _tableName = "appointment";

    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<AppointmentEntity> builder)
    {
        builder.ToTable(_tableName);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName($"{_tableName}_id").ValueGeneratedOnAdd();

        builder.Property(x => x.Guid).HasColumnName($"{_tableName}_guid").ValueGeneratedOnAdd();
        builder.Property(x => x.ClientName).HasColumnName("client_name").IsRequired(true);
        builder.Property(x => x.Phone).HasColumnName("phone").IsRequired(true);
        builder.Property(x => x.DtAppointment).HasColumnName("dt_appointment").IsRequired(true);
        builder.Property(x => x.TmBegin).HasColumnName("tm_begin").IsRequired(true);
        builder.Property(x => x.Note).HasColumnName("note").IsRequired(false);
    }
}

