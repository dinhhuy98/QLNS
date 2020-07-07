using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanSu.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLyNhanSu.Controllers
{
    [Route("api/v1/[controller]")]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowAllOrigins")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        [HttpGet]
        [Microsoft.AspNetCore.Cors.EnableCors("AllowAllOrigins")]
        public IEnumerable<Employee> Get()
        {
            return Entity.ListEmployee;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeesController>
        [HttpPost]
        [Microsoft.AspNetCore.Cors.EnableCors("AllowAllOrigins")]
        public void Post([FromBody] Employee employee)
        {
            employee.employeeId = "MF" + new Random().Next(10000);
            Entity.ListEmployee.Add(employee);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(String id, [FromBody] Employee employee)
        {
            foreach(Employee e in Entity.ListEmployee)
            {
                if (e.employeeId == id)
                {
                    int k = Entity.ListEmployee.IndexOf(e);
                    Entity.ListEmployee[k] = employee;
                    break;
                }
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(String id)
        {
            
            Employee.deleteEmployeeById(id);
            
        }
    }
}
