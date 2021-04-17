using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
    interface IRepository<IEntity> where IEntity : class
    {
        Task<IEntity> GetByIdAsync(int Id);

        Task<IEnumerable<IEntity>> GetAllAsync();

        Task<IEnumerable<IEntity>> Find(Expression<Func<IEntity, bool>> predicate);

        Task<IEntity> SingleOrDefaultAsync(Expression<Func<IEntity, bool>> predicate);

        Task AddAsync(IEntity entity);

        Task AddRangeAsync(IEnumerable<IEntity> entities);

        void Remove(IEntity entity);

        void RemoveRange(IEnumerable<IEntity> entities);

        IEntity Update(IEntity entity);
    }
}
