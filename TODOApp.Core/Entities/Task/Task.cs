using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp.Core.Entities
{
    public class Task
    {
        /// <summary>
        /// Uniquely Identifies a Task in System
        /// </summary>
        public Int32 TaskId { get; set; }

        /// <summary>
        /// Represent the Description 
        /// </summary>
        public string Description { get; set; }
    }
}
