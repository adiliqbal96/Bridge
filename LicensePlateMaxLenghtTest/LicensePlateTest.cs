using Xunit;
using System;
using Bridge;

namespace LicensePlateMaxLengthTest
{
    /// <summary>
    /// Test class to validate that vehicles enfore the maximum license plate Lenght rule.
    /// </summary>
    public class LicensePlateTest
    {
        /// <summary>
        /// Ensures that a car throws an argumentexception if the license plate exceeds 7 characters
        /// </summary>
        [Fact]
        public void LicensePlate_ShouldThrowException_IfTooLong_ForCar()
        {
            // Arrange & Act
            // Attempt to create a Car with an invalid license plate (more than 7 characters).
            // The Vehicle constructor should throw an ArgumentException.
            Assert.Throws<ArgumentException>(() => new Car("AB123456", DateTime.Now));
        }

       

        [Fact]
        public void LicensePlate_ShouldThrowException_IfTooLong_ForMC()
        {
            // Arrange & Act
            // Attempt to create an MC with an invalid license plate (more than 7 characters).
            // The Vehicle constructor should throw an ArgumentException.
            Assert.Throws<ArgumentException>(() => new MC("XY987654", DateTime.Now));
        }
    }
}