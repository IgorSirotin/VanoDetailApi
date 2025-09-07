using System;

namespace VanoDetail.Domain;

public class BaseGuid<T>
{
    public T Id { get; set; }

    public Guid Guid { get; set; }
}
