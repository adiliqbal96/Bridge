using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {
        public MC(string licensePlate, DateTime date, bool hasBroBizz = false)
            : base(licensePlate, date, hasBroBizz) { }

        public override double BasePrice() => 120; // Same as before

        public override double Price() // Keeps the same logic
        {
            double price = BasePrice();
            if (HasBroBizz)
            {
                price *= 0.90; // Apply 10% discount
            }
            return price;
        }

        public override string VehicleType() => "MC";
    }
   }