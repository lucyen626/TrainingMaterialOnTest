using ShopService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService
{
    public class Cashier : ICashier
    {
        public void Checkout(ICart cart)
        {
            foreach(var item in cart.Items)
            {
                // prepare receipt
            }
        }
    }
}
