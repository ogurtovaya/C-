using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string G;
            G = Console.ReadLine();
            int g;
            g = int.Parse(G);
            double R;
            R = g * Math.PI / 180;
            Console.WriteLine("{0:F4}", R);
        }
    }
}
