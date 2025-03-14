using System;
using Xunit;
using OresundTicketLibrary;


namespace OresundMCTests
{
    public class OresundMCTest
    {
        [Fact]
        public void Price_ShouldReturn235_WhenNoBrobizz()
        {
            var mc = new OresundMC("MC12345", DateTime.Now, false);
            Assert.Equal(235, mc.Price());
        }
        [Fact]
        public void Price_ShouldReturn92_WhenUsingBrobizz()
        {
            var mc = new OresundMC("MC12345", DateTime.Now, true);
            Assert.Equal(92, mc.Price());
        }

        [Fact]
        public void VehicleType_ShouldReturnOresundMC()
        {
            var mc = new OresundMC("MC12345", DateTime.Now, false);
            Assert.Equal("Oresund MC", mc.VehicleType());
        }
    }
}





