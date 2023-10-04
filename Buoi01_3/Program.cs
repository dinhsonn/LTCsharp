using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n=");
            int n = Convert.ToInt16(Console.ReadLine());
            int tongle = 0;
            for (int i = 1; i < 2 * n - 1; i++)
            {
                if (i % 2 != 0)
                    tongle += i;
            }
            Console.Write("Tong cac so le tu 1 den 2n-1 la: " + tongle);
            Console.ReadKey();
        }
    }
}
