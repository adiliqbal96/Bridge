namespace Bridge
{
    /// <summary>
    /// represents a car that can cross a bridge
    /// </summary>
    /// 
    public class Car : Vehicle
    {
        public Car(string licensePlate, DateTime date, bool hasBroBizz = false)
            : base(licensePlate, date, hasBroBizz) { }

        public override double BasePrice() => 230; // Same as before

        public override double Price() // Keeps the same logic
        {
            double price = BasePrice();
            if (HasBroBizz)
            {
                price *= 0.90; // Apply 10% discount
            }
            return price;
        }

        public override string VehicleType() => "Car";
    }
   }