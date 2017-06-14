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
            int x, y, z;
            string t;
            t = Console.ReadLine();
            x = int.Parse(t);
            t = Console.ReadLine();
            y = int.Parse(t);
            t = Console.ReadLine();
            z = int.Parse(t);
            if (x == y || y == z||x==z)
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу");
            }

        }
    }
}
