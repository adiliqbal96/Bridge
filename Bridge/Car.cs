namespace Bridge
{
    /// <summary>
    /// represents a car that can cross a bridge
    /// </summary>
    /// 
    public class Car
    {
        /// <summary>
        /// The car's licenseplate.
        /// </summary>
        public string Licenseplate { get; set; }


        /// <summary>
        /// The date of the crossing
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Initializes a new instance of the car class
        /// </summary>

        public Car (string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;

        }

        /// <summary>
        /// Returns the price for crossing the bridge.
        /// </summary>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
