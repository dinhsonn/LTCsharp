using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n=");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Write("Cac so nguyen to tu 1 den n la: ");
            for (int i = 1; i <= n; i++)
            {
                if (ktnt(i) == true)
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        static bool ktnt(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
