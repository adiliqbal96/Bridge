using Xunit;
using StoreBaeltTicketLibrary; 
using System;

namespace StoreBaeltTicketLibraryTest 
{
    public class StoreBaeltCarTests
    {
        [Fact]
        public void Price_ShouldApplyWeekendDiscount_WithoutBroBizz()
        {
            // Arrange - Saturday without BroBizz
            StoreBaeltCar car = new StoreBaeltCar("AB12345", new DateTime(2025, 3, 15), false);

            // Act
            double price = car.Price();

            // Assert
            Assert.Equal(230 * 0.85, price); // 15% discount applied
        }

        [Fact]
        public void Price_ShouldApplyBroBizzDiscount_OnWeekday()
        {
            // Arrange - Monday with BroBizz
            StoreBaeltCar car = new StoreBaeltCar("AB12345", new DateTime(2025, 3, 17), true);

            // Act
            double price = car.Price();

            // Assert
            Assert.Equal(230 * 0.90, price); // 10% BroBizz discount applied
        }
    }
}
