using HospitalAutomation.Application.Repositories;
using HospitalAutomation.Domain.Entities.Common;
using HospitalAutomation.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly HospitalAutomationDbContext _context;

        public WriteRepository(HospitalAutomationDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;

        }

        public bool Remove(T model)
        {
          EntityEntry<T> entityEntry =Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
          T getId = await  Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(getId);
        }

        public bool Update(T model)
        {
           EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
