using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_5
{
    internal class NhaPho : KhuDat
    {
        public int NamXd { get; set; }
        public int SoTang { get; set; }
        public NhaPho() { }
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap NamXd: ");
            NamXd = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap SoTang: ");
            SoTang = Convert.ToInt16(Console.ReadLine());
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("NamXd:{0} \t SoTang:{1} \t", NamXd, SoTang);
        }
    }
}
