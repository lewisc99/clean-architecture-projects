
using Shop.Domain.Entities;
using System.Collections.Generic;

namespace Shop.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }  
    }
}
