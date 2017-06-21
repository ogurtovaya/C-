using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            String X;
            X = Console.ReadLine();
            double x;
            x = double.Parse(X);
            double r;//ппеременная для результата
            r = x + 7;
            Console.WriteLine("{0:F4}", r);
        }
    }
}
