using System.Collections.Generic;

namespace DevFramework.Core.Infrastructure.Model
{
    public class PaginatedItem<TEntity> where TEntity : class
    {
       public int PageIndex { get; private set; }
       public int PageSize { get; private set; }
       public long Count { get; private set; }
       public int TotalPage { get; set; }

       public IEnumerable<TEntity> Data { get; private set; }

       public PaginatedItem(int pageSize,int pageIndex,long count,int totalPage , IEnumerable<TEntity> data)
       {
           this.PageIndex = pageIndex;
           this.PageSize = pageSize;
           this.Count = count;
           this.Data = data;
           this.TotalPage = totalPage;
       }
   }
}