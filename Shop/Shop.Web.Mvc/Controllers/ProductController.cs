using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Application.ViewModels;

namespace Shop.Web.Mvc.Controllers
{
    public class ProductController : Controller
    {
       private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();
            return View(model);
        }
    }
}
