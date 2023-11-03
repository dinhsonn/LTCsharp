using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_5
{
    internal class KhuDat
    {
        public string DiaDiem { get; set; }
        public double GiaBan { get; set; }
        public double DienTich { get; set; }
        public KhuDat() { }
        public void Nhap()
        {
            Console.Write("Nhap DiaDiem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap GiaBan: ");
            GiaBan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap DienTich: ");
            DienTich = Convert.ToDouble(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("DiaDiem:{0} \t GiaBan:{1} \t DienTich:{2}", DiaDiem, GiaBan, DienTich);
        }
    }
}
