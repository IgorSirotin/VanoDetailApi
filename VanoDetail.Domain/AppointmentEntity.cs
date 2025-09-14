using System;
using System.Collections.Generic;

namespace VanoDetail.Domain;

/// <summary>
/// Запись на услуги.
/// </summary>
public class AppointmentEntity : BaseGuid<int>
{
    /// <summary>
    /// Имя клиента.
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Номер телефона клиента.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Перечень услуг.
    /// </summary>
    public ICollection<ServiceEntity> Services { get; set; } = [];

    /// <summary>
    /// Дата.
    /// </summary>
    public DateOnly DtAppointment {  get; set; }

    /// <summary>
    /// Времея начала.
    /// </summary>
    public TimeOnly TmBegin { get; set; }

    /// <summary>
    /// Примечание.
    /// </summary>
    public string? Note { get; set; }
}
