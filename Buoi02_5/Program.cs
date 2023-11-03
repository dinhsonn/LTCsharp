using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<KhuDat> dsKD = NhapDSKhuDat();
            List<NhaPho> dsNP = NhapDSNhaPho();
            List<ChungCu> dsCC = NhapDSChungCu();

            Console.WriteLine("\n********Xuat danh sach khu dat**********");
            XuatDSKhuDat(dsKD);
            Console.WriteLine("\n********Xuat danh sach nha pho**********");
            XuatDSNhaPho(dsNP);
            Console.WriteLine("\n********Xuat danh sach chung cu**********");
            XuatDSChungCu(dsCC);

            Console.WriteLine("\nTong gia ban cua tung loai");
            TongGiaBan(dsKD, dsNP, dsCC);

            Console.WriteLine("\nDanh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2019 ");
            KhuDat_NhaPho_2019(dsKD, dsNP);

            Console.WriteLine("\nDanh sách cần tìm kiếm");
            TimKiem(dsNP, dsCC);


        }
        public static List<KhuDat> NhapDSKhuDat()
        {
            Console.Write("Nhap so khu dat: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.WriteLine("\n*************Nhap danh sach khu dat***************");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap khu dat thu {0}", i + 1);
                KhuDat kd = new KhuDat();
                kd.Nhap();
                listKhuDat.Add(kd);
            }
            return listKhuDat;
        }
        public static List<NhaPho> NhapDSNhaPho()
        {
            Console.Write("Nhap so nha pho: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<NhaPho> listNhaPho = new List<NhaPho>();
            Console.WriteLine("\n**************Nhap danh sach nha pho*************");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap khu nha pho {0}", i + 1);
                NhaPho np = new NhaPho();
                np.Nhap();
                listNhaPho.Add(np);
            }
            return listNhaPho;
        }
        public static List<ChungCu> NhapDSChungCu()
        {
            Console.Write("Nhap so chung cu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<ChungCu> listChungCu = new List<ChungCu>();
            Console.WriteLine("\n**************Nhap danh sach chung cu**************");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap khu chung cu {0}", i + 1);
                ChungCu cc = new ChungCu();
                cc.Nhap();
                listChungCu.Add(cc);
            }
            return listChungCu;
        }
        private static void XuatDSKhuDat(List<KhuDat> listKhuDat)
        {
            foreach (KhuDat kd in listKhuDat)
            {
                kd.Xuat();
            }
        }
        private static void XuatDSNhaPho(List<NhaPho> listNhaPho)
        {
            foreach (NhaPho np in listNhaPho)
            {
                np.Xuat();
            }
        }
        private static void XuatDSChungCu(List<ChungCu> listChungCu)
        {
            foreach (ChungCu cc in listChungCu)
            {
                cc.Xuat();
            }
        }
        private static void TongGiaBan(List<KhuDat> listKhuDat, List<NhaPho> listNhaPho, List<ChungCu> listChungCu)
        {
            double kd = listKhuDat.Sum(n => n.GiaBan);
            double np = listNhaPho.Sum(n => n.GiaBan);
            double cc = listChungCu.Sum(n => n.GiaBan);
            Console.WriteLine("Tong gia ban khu dat: {0}", kd);
            Console.WriteLine("Tong gia ban nha pho: {0}", np);
            Console.WriteLine("Tong gia ban chung cu: {0}", cc);
        }
        private static void KhuDat_NhaPho_2019(List<KhuDat> listKhuDat, List<NhaPho> listNhaPho)
        {
            var filteredProperties = listKhuDat.Where(kd => kd.DienTich > 100)
                .Concat(listNhaPho.Where(np => np.DienTich > 60 && np.NamXd >= 2019));
            if (filteredProperties.Any())//chứa ít nhất một phần tử hay không
            {
                foreach (var property in filteredProperties)
                {
                    if (property is KhuDat)
                    {
                        Console.WriteLine("Khu dat:");
                        ((KhuDat)property).Xuat();
                    }
                    else if (property is NhaPho)
                    {
                        Console.WriteLine("Nha pho:");
                        ((NhaPho)property).Xuat();
                    }
                }
            }
            else
            {
                Console.WriteLine("Không có khu đất hoặc nhà phố nào thỏa điều kiện.");
            }
        }
        private static void TimKiem(List<NhaPho> listNhaPho, List<ChungCu> listChungCu)
        {
            Console.WriteLine("\nNhập thông tin tìm kiếm:");
            Console.Write("Địa điểm cần tìm kiếm: ");
            string diaDiemCanTim = Console.ReadLine().ToLower();
            Console.Write("Giá cần tìm kiếm (VND): ");
            double giaCanTim = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diện tích cần tìm kiếm (m2): ");
            double dienTichCanTim = Convert.ToDouble(Console.ReadLine());

            List<NhaPho> locNhaPho = listNhaPho.Where(nha =>
                nha.DiaDiem.ToLower().Contains(diaDiemCanTim) &&
                nha.GiaBan <= giaCanTim &&
                nha.DienTich >= dienTichCanTim).ToList();

            List<ChungCu> locChungCu = listChungCu.Where(chungCu =>
                chungCu.DiaDiem.ToLower().Contains(diaDiemCanTim) &&
                chungCu.GiaBan <= giaCanTim &&
                chungCu.DienTich >= dienTichCanTim).ToList();
            if (locNhaPho.Count != 0)
            {
                Console.WriteLine("----------Nhà phố----------");
                XuatDSNhaPho(locNhaPho);
            }
            if (locChungCu.Count != 0)
            {
                Console.WriteLine("---------Chung cư----------");
                XuatDSChungCu(locChungCu);
            }
            if (locNhaPho.Count == 0 && locChungCu.Count == 0)
                Console.WriteLine("Không tìm thấy");
        }
    }
}
