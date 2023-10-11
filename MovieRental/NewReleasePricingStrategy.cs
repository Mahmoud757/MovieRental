using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class NewReleasePricingStrategy : IPricingStrategy
    {
        public double CalculateAmount(int dayRented)
        {   
            return dayRented * 3; 
        }
    }

}
