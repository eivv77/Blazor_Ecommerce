namespace BlazorEcommerce.Client.Services.Abstract
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetAll();
        Task<ServiceResponse<Product>> GetProduct(int productId);

    }
}
