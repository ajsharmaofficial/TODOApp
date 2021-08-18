using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using TODOApp.Application.Interfaces;
using TODOApp.Core.Entities.Base;

namespace TODOApp.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOptions<ApplicationKeys> _options;

        public UnitOfWork(IOptions<ApplicationKeys> options)
        {
            _options = options;
        }


    }
}
