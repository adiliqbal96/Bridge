using Xunit;
using Bridge;
namespace BroBizzDiscountTest
{
    public class DiscountTest
    {
        [Fact]
        public void Price_ShouldApply_10PercentDiscount_WhenBrobizzIsUsed() 
        {
            // Arrange: Car with Brobizz
            Car carWithBrobizz = new Car("AB12345", DateTime.Now, true);

            // Act: Get price with Brobizz
            double discountedPrice = carWithBrobizz.Price();

            // Assert: Check that 10% discount is applied
            Assert.Equal(207, discountedPrice, 2); // Expected: 230 - 10% = 207
        }
    }
}