using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RepositoryPattern
{
    public class EfRepoBase<TEntity, Tcontext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where Tcontext : DbContext, new()

    {
        public async Task Add(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                // var deger = context.Add(entity);
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                var deger = await context.SaveChangesAsync();
            }
        }

        public async Task Delete(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Deleted;
                var deger = await context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new Tcontext())
            {
                return await db.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new Tcontext())
            {
                return filter == null
                ? await db.Set<TEntity>().ToListAsync()
                : await db.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            List<TEntity> entities;
            using (var context = new Tcontext())
            {
                entities = await context.Set<TEntity>().ToListAsync();
            }
            return entities;
        }

        public async Task Update(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                var deger = await context.SaveChangesAsync();
            }
        }
    }
}
