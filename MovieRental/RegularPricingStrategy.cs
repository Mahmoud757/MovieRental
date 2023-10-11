using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MovieRental
{
    public class RegularPricingStrategy : IPricingStrategy
    {
        public double CalculateAmount(int dayRented)
        {
            double amount = 2;
            if (dayRented > 2)
                amount += (dayRented - 2) * 1.5;
            return amount;
        }
    }
}
