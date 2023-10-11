using System;
using Xunit;
using MovieRental;

namespace MovieRental.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void Test1()
        {
            Customer customer = new Customer("Bob");
            customer.AddRental(new Rental(new Movie("Jaws", MovieTypeEnum.REGULAR), 2));
            customer.AddRental(new Rental(new Movie("Short New", MovieTypeEnum.NEW_RELEASE), 1));
            customer.AddRental(new Rental(new Movie("Long New", MovieTypeEnum.NEW_RELEASE), 2));
            customer.AddRental(new Rental(new Movie("Toy Story", MovieTypeEnum.CHILDRENS), 4));

            RenterPointCalculator renterPointCalculator = new RenterPointCalculator(customer.GetRentals()); 
            StatementGenerator statement = new StatementGenerator(customer, renterPointCalculator);

            String expected = "" +
                "Rental Record for Bob\n" +
                "\tJaws\t2\n" +
                "\tShort New\t3\n" +
                "\tLong New\t6\n" +
                "\tToy Story\t3\n" +
                "Amount owed is 14\n" +
                "You earned 5 frequent renter points";

            Assert.Equal(expected, statement.Generate());
        }
    }
}
