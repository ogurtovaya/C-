using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
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
            R = x * Math.PI / 180;
            double t;
            t = Math.Cos(R);
            double a;
            a = 5 *t;
            Console.WriteLine("{0:F4}", a);
        }
    }
}
