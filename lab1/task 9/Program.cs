using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {  string msg;
            msg = Console.ReadLine();
            Console.WriteLine("SELECT first_name, last_name,"+ 
            "group FROM students WHERE id =" + msg);
        }
    }
}
