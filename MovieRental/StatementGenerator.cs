using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class StatementGenerator
    {
        private readonly Customer customer;
        private readonly RenterPointCalculator renterPointCalculator;

        public StatementGenerator(Customer customer, RenterPointCalculator renterPointCalculator)
        {
            this.customer = customer;
            this.renterPointCalculator = renterPointCalculator;
        }
        public string Generate()
        {
            string result = "Rental Record for " + customer.GetName() + "\n";
            foreach (Rental rental in customer.GetRentals())
            {
                result += "\t" + rental.Movie.Title + "\t" + rental.ChargeFor().ToString() + "\n";
            }
            result += "Amount owed is " + customer.TotalAmount().ToString() + "\n";
            result += "You earned " + renterPointCalculator.CalculatePoints().ToString() + " frequent renter points";
            return result;
        }
    }
}
