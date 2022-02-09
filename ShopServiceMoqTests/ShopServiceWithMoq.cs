using Xunit;
using Moq;
using ShopService.Interfaces;
using System.Linq;
using ShopService;

namespace ShopServiceMoqTests
{
    public class ShopServiceWithMoq
    {
        [Fact]
        public void Cashier_Checkout_Should_Retrieve_Cart_Items()
        {
            var cartMock = new Mock<ICart>();
            cartMock.Setup(x => x.Items).Returns(Enumerable.Empty<Product>());

            var cashier = new Cashier();

            cashier.Checkout(cartMock.Object);

            cartMock.Verify(x => x.Items, Times.Once());
            
        }
    }
}