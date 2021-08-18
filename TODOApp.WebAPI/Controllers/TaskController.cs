using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODOApp.Application.Interfaces;
using TODOApp.Core.Entities;
using TODOApp.Core.Entities.Base;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TODOApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOptions<ApplicationKeys> _options;

        public TaskController(IUnitOfWork unitOfWork, IOptions<ApplicationKeys> options)
        {
            _unitOfWork = unitOfWork;
            _options = options;
        }
        /// <summary>
        /// Return all the tasksitems currently available
        /// </summary>
        /// <returns>List of taskItem wrapped inside responseinfo</returns>
        // GET: api/<TaskController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Create a task based on given inputs
        /// </summary>
        /// <param name="taskItem">A task object specifying the title </param>
        // POST api/<TaskController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TaskItem taskItem)
        {
            var response = new ResponseInfo<int>();
            try
            {
                 response = await _unitOfWork.TaskRepository.Add(taskItem);

            }
            catch (Exception)
            {

                throw;
            }

            return Ok(response);
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
