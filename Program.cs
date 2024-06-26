using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3: ");
            int num3= Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the number 4: ");
            int num4= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result");
            Console.WriteLine(num1 * 1000 + num2 * 100 + num3 * 10 + num4);
            Console.ReadKey();

        }
    }
}
