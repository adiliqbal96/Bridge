﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {

        /// <summary>
        /// Initializes a new instance of the MC class.
        /// </summary>
        public MC(string licensePlate, DateTime date, bool hasBroBizz = false) : base(licensePlate, date, hasBroBizz) { }

        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        public override double BasePrice() => 120;
        
        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        public override string VehicleType() => "MC";

    }
}
