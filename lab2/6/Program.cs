using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            string h;
            h = Console.ReadLine();
            int B;
            B = int.Parse(b);
            int H;
            H = int.Parse(h);
            double a;
            a = B * H/ 2;
            Console.WriteLine("{0:F2}", a);


        }
    }
}
 