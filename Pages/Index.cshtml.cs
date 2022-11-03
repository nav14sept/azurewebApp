using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using azurewebApp.Models;
using azurewebApp.Services;

namespace azurewebApp.Pages
{
    public class IndexModel : PageModel
    {

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products; 
        public void OnGet()
        {
            Products= _productService.GetProducts();

        }
    }
}