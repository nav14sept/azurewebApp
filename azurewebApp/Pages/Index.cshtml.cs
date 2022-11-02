using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using azurewebApp.Models;
using azurewebApp.Services;

namespace azurewebApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products; 
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products= productService.GetProducts();

        }
    }
}