using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Domain.Common.Base;

namespace TaskFlow.Domain.Entities
{
    public class TaskItem :BaseEntity
    {
        public string Title { get; set; } = default!;

        public string Description { get; set; } = default!;

        public bool IsCompleted { get; set; } = false;
    }
}
