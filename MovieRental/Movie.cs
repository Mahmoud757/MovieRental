using System;

namespace MovieRental
{
    public record Movie
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