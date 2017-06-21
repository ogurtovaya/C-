using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Radius;
            Radius = Console.ReadLine();
            int radius;
            radius = int.Parse(Radius);
            double volume;
            volume = 4 * Math.PI * Math.Pow(radius,3)   / 3;
            Console.WriteLine("{0:F4}", volume);

        }
    }
}
