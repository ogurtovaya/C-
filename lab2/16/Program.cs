using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string X;
            X = Console.ReadLine();
            string a;
            a = Console.ReadLine();
            double x;
            x = int.Parse(X);
            double t;
            t = int.Parse(a);
            double R;
            R = Math.Sqrt(x);
            double s;
            s = Math.Sqrt(t+R);
            double b;
            b = -5 * s;
            Console.WriteLine("{0:F4}", b);

        }
    }
}
