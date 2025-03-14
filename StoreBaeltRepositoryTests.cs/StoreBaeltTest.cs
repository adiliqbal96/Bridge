using System;
using System.Collections.Generic;
using Xunit;
using StoreBaeltTicketLibrary;
using Bridge;

namespace StoreBaeltTest
{
    public class StoreBaeltRepositoryTests
    {
        private StoreBaeltRepository repository;

        public StoreBaeltRepositoryTests()
        {
            repository = new StoreBaeltRepository();
            ClearRepository(); // Reset data before each test
        }

        /// <summary>
        /// Clears the static ticket list to ensure test isolation.
        /// </summary>
        private void ClearRepository()
        {
            typeof(StoreBaeltRepository)
                .GetField("tickets", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                ?.SetValue(null, new List<Vehicle>());
        }

        [Fact]
        public void AddTicket_ShouldStoreVehicle()
        {
            // Arrange
            var car = new StoreBaeltCar("AB12345", DateTime.Now, false);

            // Act
            repository.AddTicket(car);
            var tickets = repository.GetAllTickets();

            // Assert
            Assert.Single(tickets); // Ensure exactly 1 ticket was added
            Assert.Equal("AB12345", tickets[0].LicensePlate);
        }

        [Fact]
        public void GetAllTickets_ShouldReturnAllStoredTickets()
        {
            // Arrange
            var car1 = new StoreBaeltCar("AB12345", DateTime.Now, false);
            var car2 = new StoreBaeltCar("CD67890", DateTime.Now, true);

            // Act
            repository.AddTicket(car1);
            repository.AddTicket(car2);
            var tickets = repository.GetAllTickets();

            // Assert
            Assert.Equal(2, tickets.Count); // Should return only 2 tickets, NOT old data
        }

        [Fact]
        public void GetTicketsByLicensePlate_ShouldReturnCorrectTickets()
        {
            // Arrange
            var car1 = new StoreBaeltCar("AB12345", DateTime.Now, false);
            var car2 = new StoreBaeltCar("CD67890", DateTime.Now, true);
            var car3 = new StoreBaeltCar("AB12345", DateTime.Now, true);

            // Act
            repository.AddTicket(car1);
            repository.AddTicket(car2);
            repository.AddTicket(car3);
            var foundTickets = repository.GetTicketsByLicensePlate("AB12345");

            // Assert
            Assert.Equal(2, foundTickets.Count);
            Assert.All(foundTickets, t => Assert.Equal("AB12345", t.LicensePlate));
        }
    }
}
