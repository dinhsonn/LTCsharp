﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("\n Nhap tong so sinh vien N=");
            int N = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[N];
            Console.WriteLine("\n ====Nhập danh sách sinh viên ===");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\n Nhap Sinh Vien Thu {0}", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapSV();
            }
            Console.WriteLine("\n Xuat danh sach Sinh Vien");
            foreach (SinhVien sv in arrSinhVien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}
