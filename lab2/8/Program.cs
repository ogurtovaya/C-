using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int aInitial;
            aInitial = int.Parse(a);
            int g;
            g= aInitial % 360;
            Console.WriteLine("{0}", g);
        }
    }
}
