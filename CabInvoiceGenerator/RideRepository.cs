using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    class RideRepository
    {
        Dictionary<Ride,string> rides = new Dictionary<Ride, string>();

        public void NewRide(string userId, Ride ride)
        {
            rides.Add(ride,userId);
        }

        public void GetInvoice(Ride ride, string userId)
        {
            foreach(var journey in rides)
            {
                if(journey.Value==userId)
                {
                    
                }
            }
        }
    }
}
