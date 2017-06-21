using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Radius;
            Radius = Console.ReadLine();
            int radius;
            radius = int.Parse(Radius);
            double circumference;
            circumference = 2 * Math.PI * radius;
            Console.WriteLine("{0:F4}", circumference);

        }
    }
}
