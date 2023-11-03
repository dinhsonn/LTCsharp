using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Student : Person
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public Student() { }
        public void Nhap()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("MaSV:{0} \t DiemTB:{1} \t Khoa:{2}", MaSV, DiemTB, Khoa);
        }
    }
}
