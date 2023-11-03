using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Teacher : Person
    {
        public string MaGV { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }
        public Teacher() { }
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap MaSV: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("MaGV:{0} \t Khoa:{1} \t ChucVu:{2}", MaGV, Khoa, ChucVu);
        }
    }
}
