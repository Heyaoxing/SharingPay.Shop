using Core.Model;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ElasticsearchDb
{
    public interface IRepository<T>  where T : IESEntity
    {
        IIndexResponse Add(T entity);
        IIndexResponse AddAsync(T entity);
        IBulkResponse Add(IEnumerable<T> entities);
        Task<IBulkResponse> AddAsync(IEnumerable<T> entities);

        IUpdateResponse<T> Update<T, TPartialDocument>(DocumentPath<T> documentPath, Func<UpdateDescriptor<T, TPartialDocument>, IUpdateRequest<T, TPartialDocument>> selector)
          where T : IESEntity
          where TPartialDocument : class;
        Task<IUpdateResponse<T>> UpdateAsync<T, TPartialDocument>(DocumentPath<T> documentPath, Func<UpdateDescriptor<T, TPartialDocument>, IUpdateRequest<T, TPartialDocument>> selector)
            where T : IESEntity
            where TPartialDocument : class;

        IDeleteResponse Delete(IDeleteRequest request);
        Task<IDeleteResponse> DeleteAsync(IDeleteRequest request);
        IDeleteResponse Delete<T>(DocumentPath<T> document, Func<DeleteDescriptor<T>, IDeleteRequest> selector = null) where T : IESEntity;
        Task<IDeleteResponse> DeleteAsync<T>(DocumentPath<T> document, Func<DeleteDescriptor<T>, IDeleteRequest> selector = null) where T : IESEntity;
    }
}
