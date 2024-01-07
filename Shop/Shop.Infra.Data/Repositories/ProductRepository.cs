using Shop.Domain.Entities;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Context;
using System.Collections.Generic;

namespace Shop.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
