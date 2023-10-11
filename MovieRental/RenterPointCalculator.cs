using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class RenterPointCalculator
    {
        private readonly List<Rental> rentals;

        public RenterPointCalculator(List<Rental> rentals)
        {
            this.rentals = rentals;
        }

        public int CalculatePoints()
        {
            int frequentRenterPoints = 0;
            foreach (Rental each in rentals)
            {
                frequentRenterPoints++;
                if ((each.Movie.PriceCode == Movie.NEW_RELEASE) && each.DaysRented > 1)
                    frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }
    }
}
