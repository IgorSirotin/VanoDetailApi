namespace VanoDetail.Domain;

/// <summary>
/// Услуги.
/// </summary>
public class ServiceEntity : BaseGuid<int>
{
    public string Name { get; set; }

    public int AppointmentId { get; set; }

    public AppointmentEntity Appointment { get; set; }
}
