using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Models.Repositories.Interfaces;

namespace Code_Librarian.Models.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entity;

        public Repository(DbContext context) // Generic DbContext base class, not our AppDbContext.
        {
            // Gets a reference to the DbSet without our AppDbContext.
            _entity = context.Set<TEntity>();
        }

        public TEntity GetRecord(int id) => _entity.Find(id);

        public IEnumerable<TEntity> GetAll() => _entity.ToList();

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) =>
            _entity.Where(predicate).ToList();

        // Will return just the first result if more than one result is returned.
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate) =>
            _entity.FirstOrDefault(predicate);

        // Can throw an exception if more than one result is returned.
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) =>
            _entity.SingleOrDefault(predicate);

        public void Add(TEntity entity) => _entity.Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) => _entity.AddRange(entities);

        public void Remove(TEntity entity) => _entity.Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => _entity.RemoveRange(entities);
    }
}
