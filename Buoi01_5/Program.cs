using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = Convert.ToInt16(Console.ReadLine());

            string[] dssinhvien = NhapSV(n);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("*******Danh sach sinh vien*******");
            XuatSV(dssinhvien, n);
            Console.ReadKey();
        }
        static string[] NhapSV(int n)
        {
            string[] dssinhvien = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten sinh vien thu " + (i + 1) + ": ");
                dssinhvien[i] = Console.ReadLine();
            }

            return dssinhvien;
        }

        static void XuatSV(string[] dssinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu " + (i + 1) + ": " + dssinhvien[i]);
            }
        }
    }
}
