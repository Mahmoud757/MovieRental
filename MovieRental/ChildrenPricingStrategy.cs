using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class ChildrenPricingStrategy : IPricingStrategy
    {
        public double CalculateAmount(int dayRented)
        {
            double amount = 1.5;
            if (dayRented > 3)
                amount += (dayRented - 3) * 1.5; 
            return amount;
        }

    }
}
