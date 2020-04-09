using System;
using System.Collections.Generic;
using System.Text;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Database.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public void AddRange(IEnumerable<TEntity> entities);
        public TEntity Get(params object[] ids);
        public IEnumerable<TEntity> GetAll();
        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public void DeleteRange(IEnumerable<TEntity> entities);

    }
}
