using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập a=");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhập b=");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
            Console.ReadKey();
        }
    }
}