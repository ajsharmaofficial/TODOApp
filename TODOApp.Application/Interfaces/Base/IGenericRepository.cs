using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TODOApp.Core.Entities.Base;

namespace TODOApp.Application.Base
{
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Add the entity to database
        /// </summary>
        /// <param name="entity"> entity</param>
        /// <returns>ResponseInfo with transcation status</returns>
        Task<ResponseInfo<Int32>> Add(T entity);
    }
}
