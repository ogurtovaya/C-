using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string X;
            X = Console.ReadLine();
            double x;
            x = int.Parse(X);
            double R;
            R = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
