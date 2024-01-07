using Shop.Application.ViewModels;

namespace Shop.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();
    }
}
