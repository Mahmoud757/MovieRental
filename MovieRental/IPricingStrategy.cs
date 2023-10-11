namespace MovieRental
{
    public interface IPricingStrategy
    {
        double CalculateAmount(int dayRented);
    }
}