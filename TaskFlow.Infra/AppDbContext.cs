using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Application.Database;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Infra
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options), IAppDbContext
    {
        public DbSet<TaskItem> TaskItems => Set<TaskItem>();


    }
}
