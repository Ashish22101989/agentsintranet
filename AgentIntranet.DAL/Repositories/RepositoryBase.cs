using AgentIntranet.Contracts.Repository;
using AgentIntranet.DAL.Data;
using AgentIntranet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;

namespace AgentIntranet.DAL.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        internal DataContext context;
        internal DbSet<TEntity> dbSet;

        
        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderby = null, object filter = null)
        {
            return null;
        }

        public virtual IQueryable<TEntity> GetAll(object filter)
        {
            return null;
        }
        public virtual IQueryable<TEntity> GetFullObject(object id)
        {
            return null;
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {

            if (context.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);

            dbSet.Remove(entity);
        }
        public virtual void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            Delete(entity);
        }
        public virtual void Commit(object id)
        {
            context.SaveChanges();
        }
        public virtual void Dispose(object id)
        {
            context.Dispose();
        }

    }
}
