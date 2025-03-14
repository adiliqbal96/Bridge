using System;
using Xunit;
using OresundTicketLibrary;

namespace OresundTicketLibraryTests
{
    public class OresundCarTest
    {
        [Fact]
        public void Price_ShouldReturn460_WhenNoBrobizz()
        {
            var car = new OresundCar("AB12345", DateTime.Now, false);
            Assert.Equal(460, car.Price());
        }

        [Fact]
        public void Price_ShouldReturn178_WhenUsingBrobizz()
        {
            var car = new OresundCar("AB12345", DateTime.Now, true);
            Assert.Equal(178, car.Price());
        }

        [Fact]
        public void VehicleType_ShouldReturnOresundCar()
        {
            var car = new OresundCar("AB12345", DateTime.Now, false);
            Assert.Equal("Oresund car", car.VehicleType());
        }
    }
}