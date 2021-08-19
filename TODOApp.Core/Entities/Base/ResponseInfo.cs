using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp.Core.Entities.Base
{
    public class ResponseInfo<T>
    {
        public bool ResponseStatus { get; set; }

        public string ResponseMessage  { get; set; }

        public T Data { get; set; }
        
    }
}
