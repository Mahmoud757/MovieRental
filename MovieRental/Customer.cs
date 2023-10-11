using System.Collections.Generic;
using System.Linq;

namespace MovieRental
{

    public class Customer
    {

        private string Name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental arg)
        {
            rentals.Add(arg);
        }
        public List<Rental> GetRentals()
        {
            return rentals;
        }

        public string GetName()
        {
            return Name;
        }
        
        public double TotalAmount()
        {
            return rentals.Select(r => r.ChargeFor()).Sum();
        }
    }
}

