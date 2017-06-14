using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            string t;
            t = Console.ReadLine();
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            t = Console.ReadLine();
            z = double.Parse(t);
            if (x > 3 && x < 5)
            {
                Console.WriteLine(x);
            }
            if (y > 3 && y < 5)
            {
                Console.WriteLine(y);


            } if (z > 3 && z < 5)
            {
                Console.WriteLine(z);

            }
        }
    }
}
