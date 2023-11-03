using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<KhuDat> dsKD = NhapDSKhuDat();

            Console.WriteLine("\n********Xuat danh sach khu dat**********");
            XuatDSKhuDat(dsKD);

            Console.WriteLine("\n***Xuat danh sach khu dat duoc sap xep theo dien tich tang dan***");
            DSKDSAPXEP(dsKD);

            Console.WriteLine("\n***Xuat danh sach khu dat co gia nho hon 1ty và dien tich lon hon 60m2***");
            Gia1Ty_DT60(dsKD);

            TB1m2_1000(dsKD);

            Console.ReadKey();
        }
        public static List<KhuDat> NhapDSKhuDat()
        {
            Console.Write("Nhap so khu dat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.WriteLine("\n**********Nhap danh sach khu dat*********");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap khu dat thu {0}", i + 1);
                KhuDat kd = new KhuDat();
                kd.Nhap();
                listKhuDat.Add(kd);
            }
            return listKhuDat;
        }
        private static void XuatDSKhuDat(List<KhuDat> listKhuDat)
        {
            foreach (KhuDat kd in listKhuDat)
            {
                kd.Xuat();
            }
        }
        private static void DSKDSAPXEP(List<KhuDat> listKhuDat)
        {
            List<KhuDat> listSVTB = listKhuDat.OrderBy(p => p.DienTich).ToList();
            XuatDSKhuDat(listSVTB);
        }
        private static void Gia1Ty_DT60(List<KhuDat> listKhuDat)
        {
            List<KhuDat> list = listKhuDat.Where(p => p.GiaBan < 1000000000 && p.DienTich > 60).ToList();
            if (list.Count != 0)
                XuatDSKhuDat(list);
            else
                Console.WriteLine("Khong co khu dat co gia nho hon 1ty và dien tich lon hon 60m2");
        }
        private static void TB1m2_1000(List<KhuDat> listKhuDat)
        {
            List<KhuDat> list = listKhuDat.Where(p => p.DienTich > 1000).ToList();
            double tong = 0;
            if (list.Count != 0)
            {
                foreach (KhuDat kd in listKhuDat)
                {
                    tong += kd.GiaBan / kd.DienTich;
                }
                Console.WriteLine("Don giá trung binh 1m2 cua cac khu dat dien tich lon hon 1000m2 {0}", tong / list.Count);
            }
            else
                Console.WriteLine("Khong co khu dat dien tich lon hon 1000m2");
        }
    }
}
