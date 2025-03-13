namespace Bridge
{
    /// <summary>
    /// represents a car that can cross a bridge
    /// </summary>
    /// 
    public class Car : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the Car class.
        /// </summary>
        public Car(string licensePlate, DateTime date, bool hasBroBizz = false) : base(licensePlate, date, hasBroBizz) { }

        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        public override double BasePrice() => 230;

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        public override string VehicleType() => "Car";
    }
}
        
