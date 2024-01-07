using Shop.Domain.Entities;
using System.Collections.Generic;

namespace Shop.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
