using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC
    {
        /// <summary>
        /// The mc's license plate
        /// </summary>
        public string LicensePlate {get; set;}

        /// <summary>
        /// The date of the crossing
        /// </summary>
        public DateTime Date { get; set;}

        /// <summary>
        /// Initializes a new instance of the MC class.
        /// </summary>
        public MC(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;

        }

        /// <summary>
        /// Returns the price for crossing the bridge.
        /// </summary>
        public double Price ()
        {
            return 120;
        }

        /// <summary>
        /// Returns the vehicle type.
        /// </summary>
        public string VehicleType()
        {
            return "MC";
        }

    }
}
