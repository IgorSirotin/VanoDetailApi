using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanoDetail.Domain;

/// <summary>
/// Услуги.
/// </summary>
public class ServiceEntity : BaseGuid<int>
{
    public string Name { get; set; }

    [NotMapped]
    public int AppointmentId { get; set; }

    public ICollection<AppointmentEntity> Appointments { get; set; }
}
