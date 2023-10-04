using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tam giac
            Console.Write("Nhap a=");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap b=");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap c=");
            int c = Convert.ToInt16(Console.ReadLine());

            if (a + b > c && b + c > a && c + a > b)
            {
                int P = a + b + c;
                double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.WriteLine("Chu vi tam giac: " + P);
                Console.WriteLine("Dien tich tam giac: " + S);
            }
            else
                Console.WriteLine(a + " " + b + " " + c + " " + "Không phai la 3 canh cua tam giac hop le");
            Console.ReadKey();
        }

    }
}
