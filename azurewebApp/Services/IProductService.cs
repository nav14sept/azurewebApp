using azurewebApp.Models;

namespace azurewebApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}