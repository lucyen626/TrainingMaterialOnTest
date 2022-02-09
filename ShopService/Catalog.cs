using ShopService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService
{
    public class Catalog : ICatalog
    {
        private Catalog() { }
        private List<Product> _products = new();

        public ICatalog Create()
        {
            var catalog = new Catalog();

            catalog._products.Add(new Product() 
                { Id = 1, Name = "Apple", Price = 1.5M });
            catalog._products.Add(new Product() 
                { Id = 2, Name = "Strawberry", Price = 5.9M });
            catalog._products.Add(new Product() 
                { Id = 3, Name = "Pineapple", Price = 3.2M });

            return catalog;
        }

        public IEnumerable<Product> Items => _products.AsReadOnly();
    }
}
