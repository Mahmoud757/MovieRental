using System;
using System.Collections.Generic;
using System.Linq;
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
            return rentals.Sum(each => CalculatePointsForRental(each));
        }

        private int CalculatePointsForRental(Rental rental)
        {
            int points = 1;

            if (rental.Movie.PriceCode == Movie.NEW_RELEASE && rental.DaysRented > 1)
            {
                points++;
            }
            return points;
        }
    }
}
