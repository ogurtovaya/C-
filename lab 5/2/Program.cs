using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string t;
            t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            if (a<b) {
                Console.WriteLine("Максимальное"+" "+b+"Минимальное"+a);

            }else{
                Console.WriteLine("Минимальное"+" "+a+"Максимальное"+a);
              
               
                 
                
            }
            }

        }
    }

