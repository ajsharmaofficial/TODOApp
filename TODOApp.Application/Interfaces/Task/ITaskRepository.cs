using System;
using System.Collections.Generic;
using System.Text;
using TODOApp.Application.Base;
using TODOApp.Core.Entities;

namespace TODOApp.Application.Interfaces
{
    public interface ITaskRepository : IGenericRepository<TaskItem>
    {

    }
}
