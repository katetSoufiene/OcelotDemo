using DepartementApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DepartementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementsController : ControllerBase
    {
        private readonly List<Departement> departements = new List<Departement>()
        {
            new Departement(){ Id= new Guid(), Name= "It"},
            new Departement(){ Id= new Guid(), Name= "HR"},
        };


        // GET: api/<DepartementsController>
        [HttpGet]
        public IEnumerable<Departement> Get()
        {
            return departements;
        }

        // GET api/<DepartementsController>/5
        [HttpGet("{id}")]
        public Departement Get(int id)
        {
            return departements.First();
        }

        // POST api/<DepartementsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DepartementsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartementsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
