namespace BlazorEcommerce.Server.Services.Abstract
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
