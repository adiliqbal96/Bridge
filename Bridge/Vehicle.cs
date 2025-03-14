using System;

namespace Bridge
{
    public abstract class Vehicle
    {
        public string LicensePlate { get; private set; }
        public DateTime Date { get; private set; }
        public bool HasBroBizz { get; private set; }

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
        /// Abstract method to return the base price before discounts.
        /// </summary>
        public abstract double BasePrice();

        /// <summary>
        /// Abstract method to return the final price with discounts applied.
        /// Each vehicle must implement this method.
        /// </summary>
        public abstract double Price(); // NO BODY - Abstract method!

        /// <summary>
        /// Abstract method to return the vehicle type.
        /// Each vehicle must implement this method.
        /// </summary>
        public abstract string VehicleType();
    }
}