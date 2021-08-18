using System;
using System.Collections.Generic;
using System.Text;

namespace TODOApp.Core.Entities
{
    public class TaskItem
    {
        /// <summary>
        /// Uniquely Identifies a Task in System
        /// </summary>
        public Int32 TaskId { get; set; }

        /// <summary>
        /// Represent the task title 
        /// </summary>
        public string Title { get; set; }
    }
}
