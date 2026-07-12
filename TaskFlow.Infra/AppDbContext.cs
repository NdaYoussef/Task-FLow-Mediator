using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Application.Database;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Infra
{
    public class AppDbContext : IAppDbContext
    {
        public DbSet<TaskItem> TaskItems {  get; set; }

        public void Dispose()
        {
            
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
