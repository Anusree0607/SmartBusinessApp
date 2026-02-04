using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using NetworkClient.Models;

namespace NetworkClient
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5123/")
            };
        }

        // ---------- GET METHODS ----------

        public async Task<List<Branch>> GetBranchesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Branch>>("api/branch");
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/product");
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Customer>>("api/customer");
        }

        // ---------- SAVE (POST) METHODS ----------

        public async Task<Branch> SaveBranchAsync(Branch branch)
        {
            var response = await _httpClient.PostAsJsonAsync("api/branch", branch);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Branch>();
        }

        public async Task<Product> SaveProductAsync(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync("api/product", product);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Product>();
        }

        public async Task<Customer> SaveCustomerAsync(Customer customer)
        {
            var response = await _httpClient.PostAsJsonAsync("api/customer", customer);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Customer>();
        }
    }
}
