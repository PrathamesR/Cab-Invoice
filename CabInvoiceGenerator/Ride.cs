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
        Type type;

        public enum Type { NORMAL, PREMIUM}

        public Ride(double distance,double time, Type type)
        {
            this.distance=distance;
            this.time = time;
            this.type = type;
        }

        public double CalculateFare()
        {
            if (type == Type.NORMAL)
            {
                double cost = 10 * distance + time;
                return cost > 5 ? cost : 5;
            }
            else if (type == Type.PREMIUM)
            {
                double cost = 15 * distance + 2 * time;
                return cost > 20 ? cost : 20;
            }
            else
                return 0;
        }
    }
}
