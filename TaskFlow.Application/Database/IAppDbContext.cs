using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Database
{
    public interface IAppDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet<TaskItem> TaskItems { get;}

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
