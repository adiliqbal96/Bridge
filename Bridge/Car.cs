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
        public Car(string licensePlate, DateTime date) : base(licensePlate, date) { }

        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        public override double Price() => 230;

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        public override string VehicleType() => "Car";
    }
}
        
