using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundTicketLibrary
{
    public class OresundCar : Car
    {
        public OresundCar(string licensePlate, DateTime date, bool hasBroBizz = false)
            : base(licensePlate, date, hasBroBizz) { }

        public override double Price()
        {
            // If Brobizz is used, return 178 kr, otherwise, return 460 kr
            return HasBroBizz ? 178 : 460;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}