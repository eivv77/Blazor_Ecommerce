using BlazorEcommerce.Client.Services.Abstract;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetAll()
        {
            var result =
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }
    }
}
