using System;
namespace DevFramework.Core.Infrastructure.Repository
{
    public interface IRepositoryFactory
    {        
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
