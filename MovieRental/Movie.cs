using System;

namespace MovieRental
{
    public class Movie
    {
        public String Title { get; set; }
        public MovieTypeEnum PriceCode { get; set; }

        public Movie(String title, MovieTypeEnum priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

    }
}