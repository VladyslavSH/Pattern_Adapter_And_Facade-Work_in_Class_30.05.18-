using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.RaundPeg
{
    public class RaundPeg :IRaundPeg
    {
        double radius;
        public RaundPeg(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }
    }
}
