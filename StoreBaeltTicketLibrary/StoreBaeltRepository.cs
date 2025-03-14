using System;
using System.Collections.Generic;
using System.Linq;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltRepository : IStoreBaeltRepository  // Implement the interface
    {
        // Static list to store all tickets
        private static List<Vehicle> tickets = new List<Vehicle>();

        /// <summary>
        /// Adds (buys) a new ticket for a vehicle crossing Storebælt.
        /// </summary>
        /// <param name="vehicle">The vehicle for which a ticket is bought.</param>
        public void AddTicket(Vehicle vehicle)
        {
            tickets.Add(vehicle);
        }

        /// <summary>
        /// Returns all tickets.
        /// </summary>
        /// <returns>A list of all tickets.</returns>
        public List<Vehicle> GetAllTickets()
        {
            return tickets;
        }

        /// <summary>
        /// Finds all tickets for a specific license plate.
        /// </summary>
        /// <param name="licensePlate">The license plate to search for.</param>
        /// <returns>A list of tickets matching the license plate.</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            return tickets.Where(t => t.LicensePlate == licensePlate).ToList();
        }
    }
}
