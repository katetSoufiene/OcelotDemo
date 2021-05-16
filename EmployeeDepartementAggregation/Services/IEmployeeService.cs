using EmployeeDepartementAggregation.Extensions;
using EmployeeDepartementAggregation.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeDepartementAggregation.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAsync();
        Task<Employee> GetAsync(string id);
    }


    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _client;

        public EmployeeService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<Employee>> GetAsync()
        {
            try
            {
                var response = await _client.GetAsync($"/api/employees");
                return await response.ReadContentAs<IEnumerable<Employee>>();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Employee> GetAsync(string id)
        {
            try
            {
                var response = await _client.GetAsync($"/api/employees/{id}");
                return await response.ReadContentAs<Employee>();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
