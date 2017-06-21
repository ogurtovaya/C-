using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string X;
            X = Console.ReadLine();
            double x;
            x= int.Parse(X);
            double R;
            R = x * Math.PI / 180;
            double t;
            t = Math.Sin(R);
            Console.WriteLine("{0:F4}", t);
        }
    }
}
