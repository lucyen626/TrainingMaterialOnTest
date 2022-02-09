using ShopService;
using ShopService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopServiceMockingTests
{
    public class CartMock : ICart
    {

        public bool ItemsCalled = false;
        public IEnumerable<Product> Items
        {
            get
            {
                ItemsCalled = true;
                return Enumerable.Empty<Product>();
            }
        }

        public decimal Total => throw new NotImplementedException();

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
