using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Domain.Common.Shared;

namespace TaskFlow.Domain.Common.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
    public abstract class BaseEntity : IBaseEntity, IAuditable, ISoftDeletable
    {
        public Guid Id { get; set ; }= Guid.CreateVersion7(); //time-based GUID

        public DateTime CreatedAt { get; set ; }

        public Guid? CreatedBy { get; set ; }

        public DateTime? ModifiedAt { get; set ; }
        public Guid? ModifiedBy { get; set ; }

        public bool IsDeleted { get; set ; }

        public DateTime? DeletedAt { get; set ; }

        public void SoftDelete()
        {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }

        public void UndoDelete()
        {
            IsDeleted = false;
            DeletedAt = null;
        }
    }
}
