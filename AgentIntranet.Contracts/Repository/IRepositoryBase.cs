
namespace AgentIntranet.Contracts.Repository
{
    public interface IRepositoryBase<TEntity>
     where TEntity : class
    {
        void Commit(object id);
        void Delete(object id);
        void Delete(TEntity entity);
        void Dispose(object id);
        System.Linq.IQueryable<TEntity> GetAll();
        System.Linq.IQueryable<TEntity> GetAll(object filter);
        TEntity GetById(object id);
        System.Linq.IQueryable<TEntity> GetFullObject(object id);
        System.Linq.IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderby = null, object filter = null);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}
