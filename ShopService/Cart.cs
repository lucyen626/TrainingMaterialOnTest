using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ShopService.Interfaces;

namespace ShopService
{
    public class Cart : ICart
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Remove(Product product)
        {
            _products.Remove(_products.First(q => q.Id == product.Id));
        }

        public decimal Total => _products.Sum(q => q.Price);

        public IEnumerable<Product> Items => _products.AsReadOnly();

    }
}
