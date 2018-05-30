using ConsoleApp1.RaundPeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.SquarePeg;

namespace ConsoleApp1.Adapter
{
    public class SquarePegAdapter : IRaundPeg
    {
        ConsoleApp1.SquarePeg.SquarePeg peg = null;
        public SquarePegAdapter(ConsoleApp1.SquarePeg.SquarePeg peg)
        {
            this.peg = peg;
        }
        public double getRadius()
        {
            double halfWidth = peg.GetWidth / 2;
            Console.WriteLine($"{Math.Sqrt(Math.Pow(halfWidth, 2) * 2)}");
            return Math.Sqrt(Math.Pow(halfWidth, 2) * 2);
           
        }
    }
}