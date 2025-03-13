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
        public string LicensePlate {  get; private set; }

        /// <summary>
        /// The date of the crossing.
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Indicates whether a brobizz discount is applied
        /// </summary>
        public bool HasBroBizz {  get; private set; }

        /// <summary>
        ///  Initializes a new instance of the Vehicle class.
        ///  Throws an exception if the licenseplate is longer than 7 characters.
        /// </summary>
        /// <param name="licensePlate"> The vehicles licenseplate</param>
        /// <param name="date"> the date of crossing</param>
        /// <exception cref="ArgumentException">Thrown if the license plate is longer than 7 characters</exception>
        public Vehicle(string licensePlate, DateTime date, bool hasBroBizz = false)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 characters.");
            }

            LicensePlate = licensePlate;
            Date = date;
            HasBroBizz = hasBroBizz;
        }

        /// <summary>
        /// Returns the base price before any discounts.
        /// </summary>
        public abstract double BasePrice();

        /// <summary>
        /// Returns the final price with Brobizz discount if applicable.
        /// </summary>
        public double Price() 
        {    
            double price = BasePrice();
            if (HasBroBizz)
            {
                price *= 0.90; // apply 10 % discount
            }
            return price;   
        } 

        /// <summary>
        /// Abstract method to return the vehicle type.
        /// Each vehicle must implement this method.
        /// </summary>
        public abstract string VehicleType();
    }
}
