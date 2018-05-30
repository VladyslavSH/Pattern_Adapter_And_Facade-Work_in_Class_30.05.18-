using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SquarePeg
{
    public class SquarePeg
    {
        double width;
        public SquarePeg(double width)
        {
            this.width = width;
        }
        public double GetWidth {
            get {
                return width;
            }
        }
        
    }
}
