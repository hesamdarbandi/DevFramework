using System;
using System.Collections.Generic;
using DevFramework.Core.Infrastructure.PagedList;
using DevFramework.Core.Infrastructure.Repository;

namespace DevFramework.Core.Infrastructure.Extension.PagedList
{
    public static class IEnumerablePagedListExtensions
    {
        
        public static IPagedList<T> ToPagedList<T>(this System.Collections.Generic.IEnumerable<T> source, int pageIndex, int pageSize, int indexFrom = 0) => new PagedList<T>(source, pageIndex, pageSize, indexFrom);

        public static IPagedList<TResult> ToPagedList<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter, int pageIndex, int pageSize, int indexFrom = 0) => new PagedList<TSource, TResult>(source, converter, pageIndex, pageSize, indexFrom);
    }
}
