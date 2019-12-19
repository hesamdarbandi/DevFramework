using System;
using System.Threading.Tasks;
using DevFramework.Core.Infrastructure.Repository;
using DevFramework.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace DevFramework.Data.Repository
{
    public class RequestRepository<TContext> : BaseRepository<Request>, IRequestRepository where TContext : DbContext
    {
        public RequestRepository(TContext dbContext) : base(dbContext)
        {

        }

    }
}