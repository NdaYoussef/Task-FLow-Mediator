using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Domain.Common.Shared
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; }
        Guid? CreatedBy { get; }
        DateTime? ModifiedAt { get; }
        Guid? ModifiedBy { get; }
    }
}
