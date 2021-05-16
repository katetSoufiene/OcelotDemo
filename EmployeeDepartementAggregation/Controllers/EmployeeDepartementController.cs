using EmployeeDepartementAggregation.Models;
using EmployeeDepartementAggregation.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDepartementAggregation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDepartementController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        private readonly IDepartementService departementService;

        public EmployeeDepartementController(IEmployeeService employeeService, IDepartementService departementService)
        {
            this.employeeService = employeeService;
            this.departementService = departementService;
        }


        // GET: api/<EmployeeDepartementController>
        [HttpGet]
        public async Task<IEnumerable<EmployeeDepartement>> GetAsync()
        {
            var departement = await departementService.GetAsync();

            var employees = await employeeService.GetAsync();

            //todo add all  EmployeeDepartement
            var employeesDeprtements = new List<EmployeeDepartement>();

            return employeesDeprtements;
        }

        // GET api/<EmployeeDepartementController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {

            var employee = await employeeService.GetAsync(id);

            var departements = await departementService.GetAsync();

            var employeeDepamtments = new EmployeeDepartement();

            employeeDepamtments.Employee = employee;

            employeeDepamtments.Departement = departements.Single(d => employee.DepartementId == d.Id);          


            return Ok(employeeDepamtments);
        }

        // POST api/<EmployeeDepartementController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeDepartementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeDepartementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
