using System.Security.Cryptography.X509Certificates;
using Bridge;

namespace BridgeMCTest
{
    public class MCTest
    {
        /// <summary>
        /// Test that the Price() method returns the expected fixed price of 120.
        /// </summary>

        [Fact]
        public void Price_ShouldReturn_120()
        {

            //Arrange: Create an MC object
            MC mc = new MC("MC12345", DateTime.Now);

            double price = mc.Price();

            Assert.Equal(120, price);
        }


        /// <summary>
        /// Test that the vehicleType() method correctly returns "MC".
        /// </summary>
        [Fact]
        public void VehicleType_ShouldReturn_MC()
            {

            //Arrange: Create an MC object
            MC mc = new MC("MC12345", DateTime.Now);

            //Act: Call the VehicleType() method
            string type = mc.VehicleType();

            //Assert: Check that it returns "MC"
            Assert.Equal("MC", type);


            }

        }
    }
