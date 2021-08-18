using System;
using System.Collections.Generic;
using System.Text;
using TODOApp.Core.Entities.Base;

namespace TODOApp.Application.Base
{
    interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Add the entity to database
        /// </summary>
        /// <param name="entity"> entity</param>
        /// <returns>ResponseInfo with transcation status</returns>
        ResponseInfo<T> Add(T entity);
    }
}
