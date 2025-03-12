using Xunit;
using Bridge; 

/// <summary>
/// Unit tests for the Car class.
/// </summary>
public class CarTests
{
    [Fact]
    /// <summary>
    /// Tests that the Price() method returns the expected fixed price of 230.
    /// </summary>
    public void Price_ShouldReturn_230()
   {
        // Arrange
        Car car = new Car("AB12345", DateTime.Now); // No need for "Bridge.Car"

        // Act
        double price = car.Price();

        // Assert
        Assert.Equal(230, price);
    }
    /// <summary>
    /// Tests that the vehicleType() method correctly returns "Car".
    /// /// </summary>
    ///
    [Fact]
   public void VehicleType_ShouldReturn_Car()
    {
        // Arrange: Create a new Car instance.
        Car car = new Car("AB12345", DateTime.Now); // No need for "Bridge.Car"

        // Act: Call the VechicleType() method to get the vehicle type
        string type = car.VehicleType();

        // Assert: Verify that the returned vehicle type is "Car"
        Assert.Equal("Car", type);
    }
}
