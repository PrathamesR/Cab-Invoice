using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<Ride,string> rides = new Dictionary<Ride, string>();

        public void NewRide(Ride ride, string userId)
        {
            rides.Add(ride,userId);
        }

        public Invoice GetInvoice(string userId)
        {
            Invoice invoice = new Invoice();
            foreach(var journey in rides)
            {
                if(journey.Value==userId)
                {
                    invoice.AddRide(journey.Key);
                }
            }
            return invoice;
        }
    }
}
