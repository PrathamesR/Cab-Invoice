using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    class Invoice
    {
        List<Ride> rides = new List<Ride>();

        public void AddRide(Ride ride)
        {
            rides.Add(ride);
        }

        public void DisplayInvoice()
        {
            Console.WriteLine("Total number of Rides : "+rides.Count);

            double total=0;
            foreach(Ride ride in rides)
                total += ride.CalculateFare();

            Console.WriteLine("Total Fare : " + total);

            Console.WriteLine("Average Fare per Ride : " + total / rides.Count);
        }
    }
}
