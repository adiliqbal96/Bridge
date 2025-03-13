using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Represents a Storebælt-specific car.
    /// </summary>
    public class StoreBaeltCar : Car
    {
        public StoreBaeltCar(string licensePlate, DateTime date)
            : base(licensePlate, date) { }
    }
}
