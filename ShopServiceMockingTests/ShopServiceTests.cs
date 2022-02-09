using ShopService;
using Xunit;

namespace ShopServiceMockingTests
{
    public class ShopServiceTests
    {
        [Fact]
        public void Cashier_Checkout_Should_Retrieve_Cart_Items()
        {
            var cart = new CartMock();
            var cashier = new Cashier(); // use real cashier 

            cashier.Checkout(cart); // with our fake cart


            Assert.True(cart.ItemsCalled); // check if cashier did retrive cart items

        }


    }
}