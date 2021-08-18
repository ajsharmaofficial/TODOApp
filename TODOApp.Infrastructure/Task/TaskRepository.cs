using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TODOApp.Application.Interfaces;
using TODOApp.Core.Entities;
using TODOApp.Core.Entities.Base;

namespace TODOApp.Infrastructure
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IOptions<ApplicationKeys> _options;
        public TaskRepository(IOptions<ApplicationKeys> options)
        {
            _options = options;
        }
        public Task<ResponseInfo<Int32>> Add(TaskItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
