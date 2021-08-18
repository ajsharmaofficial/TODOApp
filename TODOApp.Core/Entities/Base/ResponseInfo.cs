using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp.Core.Entities.Base
{
    public class ResponseInfo<T> where T : class
    {
        public string ResponseCode { get; set; }

        public string ResponseMessage  { get; set; }

        public List<T> Data { get; set; }
        
    }
}
