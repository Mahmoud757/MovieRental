namespace MovieRental
{
    public class Rental
    {
        public Movie Movie { get; set; }
        public int DaysRented { get; set; }

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public double ChargeFor()
        {
            IPricingStrategy pricingStrategy = null;

            switch (Movie.PriceCode)
            {
                case MovieTypeEnum.REGULAR:
                    pricingStrategy = new RegularPricingStrategy();
                    break;
                case MovieTypeEnum.NEW_RELEASE:
                    pricingStrategy = new NewReleasePricingStrategy();
                    break;
                case MovieTypeEnum.CHILDRENS:
                    pricingStrategy = new ChildrenPricingStrategy();
                    break;
            }
            return pricingStrategy.CalculateAmount(DaysRented);
        }
    }
}
