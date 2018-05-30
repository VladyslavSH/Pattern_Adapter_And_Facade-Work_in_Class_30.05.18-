using ConsoleApp1.Hole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.RaundPeg;
using ConsoleApp1.SquarePeg;
using ConsoleApp1.Adapter;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole roundHole = new RoundHole(12.0);
            IRaundPeg raundPeg = new RaundPeg.RaundPeg(10.0);
            SquarePeg.SquarePeg squarePeg = new SquarePeg.SquarePeg(16.0); 
            SquarePegAdapter squarePegAdapter = new SquarePegAdapter(squarePeg);

            Console.WriteLine(roundHole.fits(raundPeg));

            Console.WriteLine(roundHole.fits(squarePegAdapter));
        }
    }
}
