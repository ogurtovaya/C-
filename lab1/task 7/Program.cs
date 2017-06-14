using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String msg;
               msg = Console.ReadLine();
            double a;//Обьявляем переменную для числа
            a = Double.Parse(msg);//Преобразуем текст
                Console.WriteLine("{0:F4}",a);
            //Console.Write("{1} {0}", 3.7); 7 3
                //String msg;
                //msg = Console.ReadLine();
                //double int;//Обьявляем переменную для числа
                //int = Double.Parse(msg);//Преобразуем текст
                //Console.WriteLine("{0:F4}", int);(если целое число)
        }
    }
}
