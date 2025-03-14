using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundTicketLibrary
{
    public class OresundMC : MC
    {
        public OresundMC(string licensePlate, DateTime date, bool hasBroBizz = false)
               : base(licensePlate, date, hasBroBizz) { }

        public override double Price()
        {
            // If Brobizz is used, return 92 kr, otherwise, return 235 kr
            return HasBroBizz ? 92 : 235;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
