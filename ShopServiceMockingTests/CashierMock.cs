using ShopService;
using ShopService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopServiceMockingTests
{
    public class CashierMock : ICashier
    {
        public bool CheckoutCalled = false;
        public void Checkout(ICart cart)
        {
            CheckoutCalled = true;

            foreach(var item in cart.Items)
            {
                // 
            }
        }
    }
}
