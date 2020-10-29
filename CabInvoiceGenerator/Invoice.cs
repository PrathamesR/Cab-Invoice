using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Invoice
    {
        List<Ride> rides = new List<Ride>();

        public void AddRide(Ride ride)
        {
            rides.Add(ride);
        }

        public double GetAggregate()
        {
            double total = 0;
            foreach (Ride ride in rides)
                total += ride.CalculateFare();

            return total;
        }

        public int NumberOfRides()
        {
            return rides.Count;
        }

        public double GetAverage()
        {
            return GetAggregate() / rides.Count;
        }

        public void DisplayInvoice()
        {
            Console.WriteLine("Total number of Rides : "+rides.Count);
            Console.WriteLine("Total Fare : " + GetAggregate());
            Console.WriteLine("Average Fare per Ride : " + GetAverage());
        }

        public override bool Equals(object obj)
        {
            Invoice other = (Invoice)obj;
            foreach(Ride ride in rides)
                if (!other.rides.Contains(ride))
                    return false;
            return true;
        }
    }
}
