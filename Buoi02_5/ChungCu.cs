using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_5
{
    internal class ChungCu : KhuDat
    {
        public int SoTang { get; set; }
        public ChungCu() { }
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap SoTang: ");
            SoTang = Convert.ToInt16(Console.ReadLine());
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("SoTang:{0} \t", SoTang);
        }
    }
}
