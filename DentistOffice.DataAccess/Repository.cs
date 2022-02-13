using DentistOffice.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistOffice.DataAccess
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly DentistOfficeContext context;
        private DbSet<T> entities;

        public Repository(DentistOfficeContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public Task<List<T>> GetAll()
        {
            return entities.ToListAsync();
        }

        public Task<T> GetById(int id)
        {
            return entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            return context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            return context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T entity = await entities.SingleOrDefaultAsync(s => s.Id == id);
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
