using DevFramework.Core.Infrastructure.Repository;
using DevFramework.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace DevFramework.Data.Repository
{
    public class DistanceRepository<TContext> : BaseRepository<Distance>, IDistanceRepository where TContext : DbContext
    {
        public DistanceRepository(TContext dbContext) : base(dbContext)
        {

        }

    }
}