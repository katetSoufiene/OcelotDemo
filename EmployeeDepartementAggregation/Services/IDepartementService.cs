using EmployeeDepartementAggregation.Extensions;
using EmployeeDepartementAggregation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeDepartementAggregation.Services
{
    public interface IDepartementService
    {
        Task<IEnumerable<Departement>> GetAsync();

        Task<Departement> GetAsync(string id);
    }


    public class DepartementService : IDepartementService
    {
        private readonly HttpClient _client;

        public DepartementService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }


        public async Task<IEnumerable<Departement>> GetAsync()
        {
            try
            {
                var response = await _client.GetAsync($"/api/departements");
                return await response.ReadContentAs<IEnumerable<Departement>>();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Departement> GetAsync(string id)
        {
            try
            {
                var response = await _client.GetAsync($"/api/departements/{id}");
                return await response.ReadContentAs<Departement>();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
