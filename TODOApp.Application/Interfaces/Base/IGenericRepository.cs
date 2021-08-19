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
        Task<ResponseInfo<Int32>> AddAsync(T entity);

        /// <summary>
        /// Returns all the tasks present in the system
        /// </summary>
        /// <returns></returns>
        Task<ResponseInfo<IEnumerable<T>>> GetAllAsync();
    }
}
