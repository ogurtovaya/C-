using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
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
            R = Math.Sqrt(61-x);
            double c;
            c = 3 * R;
            Console.WriteLine("{0:F4}", c);

        }
    }
}
