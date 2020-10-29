using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        double distance;
        double time;

        public Ride(double distance,double time)
        {
            this.distance=distance;
            this.time = time;
        }

        public double CalculateFare()
        {
            double cost = 10 * distance + time;
            return cost>5?cost:5;
        }
    }
}
