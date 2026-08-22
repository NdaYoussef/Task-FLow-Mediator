using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Domain.Common.Shared
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; }
        DateTime? DeletedAt { get; }
        void SoftDelete();
        void UndoDelete();
    }
}
