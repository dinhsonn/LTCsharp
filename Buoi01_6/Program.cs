using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c=");
            double c = Convert.ToDouble(Console.ReadLine());
            //double x;
            if (a == 0)
            {
                //giai phuong trinh bat 1
                if (b != 0)
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình có một nghiệm duy nhất x=" + x);
                }
                else
                    if (c != 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                else
                    Console.WriteLine("Phương trình có vô số nghiệm");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1=" + x1 + ", x2=" + x2);
                }
                else
                    if (delta == 0)
                {
                    double xx = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep: x1=x2=" + xx);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            Console.ReadKey();
        }
    }
}
