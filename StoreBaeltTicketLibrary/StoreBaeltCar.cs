using Bridge; // Import the base library

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        public StoreBaeltCar(string licensePlate, DateTime date, bool hasBroBizz = false)
            : base(licensePlate, date, hasBroBizz) { }

        public override double Price()
        {
            double price = BasePrice(); // Get base price from Car

            // Apply 15% discount if it's a weekend
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85; // Reduce by 15%
            }

            // Apply 10% BroBizz discount (after weekend discount)
            if (HasBroBizz)
            {
                price *= 0.90; // Reduce by 10%
            }

            return price;
        }
    }
}
