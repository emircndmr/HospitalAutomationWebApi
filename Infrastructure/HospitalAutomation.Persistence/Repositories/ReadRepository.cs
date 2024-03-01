using HospitalAutomation.Application.Repositories;
using HospitalAutomation.Domain.Entities.Common;
using HospitalAutomation.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly HospitalAutomationDbContext _context;

        public ReadRepository(HospitalAutomationDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        => Table;

        public async Task<T> GetSingleAsync(string id)
        => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);
    }
}
