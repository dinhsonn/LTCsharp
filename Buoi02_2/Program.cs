using Buoi02_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Buoi02_2.Program;

namespace Buoi02_2
{
    internal class Program
    {
        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> ListSinhVien = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien n=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ==== Nhap danh sach sinh vien ====");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap sinh vien thu : {0}", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                ListSinhVien.Add(sv);
            }
            return ListSinhVien;

        }
        private static void XuatDSSinhVien(List<SinhVien> listSinhVien)
        {
            Console.WriteLine("\n====Xuat danh sach sinh vien====");
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }
        private static void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT1 = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT");
            }
            else
            {
                Console.WriteLine("Sinh viên khoa CNTT:");
                XuatDSSinhVien(listCNTT1);
            }

        }
        private static void DSSVLONHON5CNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT1 = listSinhVien.Where(sv => sv.DiemTB >= 5 && sv.Khoa == "CNTT").ToList();
            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT và điểm trung bình lơn 5");
            }
            else
            {
                Console.WriteLine("Sinh viên khoa CNTT và điểm trung bình lơn 5:");
                XuatDSSinhVien(listCNTT1);
            }

        }


        private static void DSSVLONHON5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên có điểm lơn hơn 5");
            }
            else
            {
                Console.WriteLine("Sinh viên có điểm lơn hơn 5:");
                XuatDSSinhVien(listSV);
            }
        }
        private static void DSSVSAPXEP(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            Console.WriteLine("Danh sách sinh vien sắp xếp theo thứ tự:");
            XuatDSSinhVien(listSV);
        }

        private static void DSSVMaxCNTT(List<SinhVien> listSV)
        {

            List<SinhVien> listSVCNTT = listSV.Where(p => (p.Khoa == "CNTT")).ToList();
            if (listSVCNTT.Count() == 0)
            {
                throw new Exception("Không có sinh viên khoa CNTT");
            }
            double maxDiemTB = (listSV.Where(sv => sv.Khoa == "CNTT")).Max(sv => sv.DiemTB);
            List<SinhVien> listSVMaxCNTT = listSV.Where(sv => sv.Khoa == "CNTT" && sv.DiemTB == maxDiemTB).ToList();
            Console.WriteLine("Danh sách sinh vien có điểm trung bình cao nhất và thuộc khoa CNTT:");
            XuatDSSinhVien(listSVMaxCNTT);
        }


        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<SinhVien> listSinhVien = NhapDSSinhVien();
            XuatDSSinhVien(listSinhVien);
            DSSVCNTT(listSinhVien);
            DSSVLONHON5(listSinhVien);
            DSSVSAPXEP(listSinhVien);
            DSSVLONHON5CNTT(listSinhVien);
            DSSVMaxCNTT(listSinhVien);
            Console.ReadKey();
        }

    }

}
