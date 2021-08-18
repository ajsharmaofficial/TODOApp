using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp.Core.Entities.Base
{
    public class ApplicationKeys
    {
        public DBConnectionStringModel DBConnectionString { get; set; }
    }

    public class DBConnectionStringModel
    {
        public string DefaultConnection { get; set; }
    }
}
