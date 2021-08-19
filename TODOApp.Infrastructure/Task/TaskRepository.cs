using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOApp.Application.Interfaces;
using TODOApp.Core.Entities;
using TODOApp.Core.Entities.Base;

namespace TODOApp.Infrastructure
{
    public class TaskRepository : ITaskRepository
    {
        private readonly string _dbConnectionString;
        public TaskRepository(IOptions<ApplicationKeys> options)
        {
            _dbConnectionString = options.Value.DBConnectionString.DefaultConnection;
        }
        public async Task<ResponseInfo<Int32>> AddAsync(TaskItem entity)
        {
            var responseInfo = new ResponseInfo<int>();

            var taskId = 0; // taskId initilization

            try
            {
                var sql = @"INSERT INTO dbo.tbl_tasks
                            ([Title],TaskStatus
                            ,[LastUpdatedAt])
                            values(@Title,@TaskStatus, @lastupdatedat);select CAST(SCOPE_IDENTITY() as INT)";

                entity.LastUpdatedAt = DateTime.UtcNow;
                entity.TaskStatus = Core.Entities.TaskStatus.PENDING;
                using (var con = new SqlConnection(_dbConnectionString))
                {
                    con.Open();
                    var result = await con.QueryAsync<int>(sql,entity);

                    //getting the one element in the sequence
                    taskId = result.Single();

                }
                responseInfo.ResponseStatus = true;
                responseInfo.ResponseMessage = "A task has been created";
                responseInfo.Data = taskId;
            }
            catch (Exception ex)
            {
                responseInfo.ResponseStatus = false;
                responseInfo.ResponseMessage = "An Error has Occured while creating the task";
                responseInfo.Data = taskId;
                
            }
            return responseInfo;
        }

        public async Task<ResponseInfo<IEnumerable<TaskItem>>> GetAllAsync()
        {
            var responseInfo = new ResponseInfo<IEnumerable<TaskItem>>();

            try
            {
                var sql = @"select * from tbl_tasks";

               
                using (var con = new SqlConnection(_dbConnectionString))
                {
                    con.Open();
                    var result = await con.QueryAsync<TaskItem>(sql);

                    responseInfo.Data = result;
                    responseInfo.ResponseStatus = true;
                    responseInfo.ResponseMessage = "Task Reterived Successfully";

                }
               
                
            }
            catch (Exception ex)
            {
                responseInfo.ResponseStatus = false;
                responseInfo.ResponseMessage = "An Error has Occured while creating the task";
               

            }
            return responseInfo;
        }
    }
}
