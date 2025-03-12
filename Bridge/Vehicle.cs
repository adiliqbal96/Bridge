using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        /// <summary>
        /// The vehicles licenseplate
        /// </summary>
        public string LicensePlate {  get; set; }

        /// <summary>
        /// The date of the crossing.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the Vehicle Class
        /// </summary>
        public Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Abstract method to return the price for crossing the bridge.
        /// Each vehicle must implement this method
        /// </summary>
        public abstract double Price();

        /// <summary>
        /// Abstract method to return the vehicle type.
        /// Each vehicle must implement this method.
        /// </summary>
        public abstract string VehicleType();
    }
}
