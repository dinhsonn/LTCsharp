using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Person
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public Person() { }
        public void Nhap()
        {
            Console.Write("Nhap CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            DiaChi = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.Write("CMND:{0} \t HoTen:{1} \t DiaChi:{2} \t", CMND, HoTen, DiaChi);
        }
    }
}
