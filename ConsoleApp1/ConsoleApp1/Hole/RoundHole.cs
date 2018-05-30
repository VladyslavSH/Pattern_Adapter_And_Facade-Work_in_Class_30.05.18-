using ConsoleApp1.RaundPeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hole
{
    public class RoundHole:IRaundPeg
    {
        double radius;
        public RoundHole(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }
        public bool fits(IRaundPeg raundPeg)
        {
            return (radius >= raundPeg.getRadius()) ? true : false;
        }
    }
}
