using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<Student> dsSV = NhapDSStudent();
            List<Teacher> dsGV = NhapDSTeacher();

            Console.WriteLine("\n***Xuat danh sach sinh vien***");
            XuatDSStudent(dsSV);

            Console.WriteLine("\n***Xuat danh sach giao vien***");
            XuatDSTeacher(dsGV);

            Console.WriteLine("\n***Xuat danh sach sinh vien thuoc khoa CNTT***");
            DSSVCNTT(dsSV);

            Console.WriteLine("\n***Xuat danh sach sinh vien co diem trung < 5 thuoc khoa CNTT ***");
            DSSV5CNTT(dsSV);

            Console.WriteLine("\n***Xuat danh sach giao vien quan 9***");
            DSGVQ9(dsGV);

            Console.WriteLine("\n***Xuat danh sach giao vien co ma CHN060286***");
            GvCHN060286(dsGV);

            Console.WriteLine("\n***Xuat danh sach sinh vien co diem trung binh lon nhat thuoc khoa CNTT***");
            DSSVMaxCNTT(dsSV);

            Console.ReadKey();
        }
        //sinh vien
        public static List<Student> NhapDSStudent()
        {
            Console.Write("Nhap so sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Student> listStudent = new List<Student>();
            Console.WriteLine("\n***Nhap danh sach sinh vien***");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                Student sv = new Student();
                sv.Nhap();
                listStudent.Add(sv);
            }
            return listStudent;
        }
        private static void XuatDSStudent(List<Student> listSV)
        {
            foreach (Student sv in listSV)
            {
                sv.Xuat();
            }
        }
        //giao vien
        public static List<Teacher> NhapDSTeacher()
        {
            Console.Write("Nhap so sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Teacher> listTeacher = new List<Teacher>();
            Console.WriteLine("\n***Nhap danh sach sinh vien***");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                Teacher gv = new Teacher();
                gv.Nhap();
                listTeacher.Add(gv);
            }
            return listTeacher;
        }
        private static void XuatDSTeacher(List<Teacher> listGV)
        {
            foreach (Teacher gv in listGV)
            {
                gv.Xuat();
            }
        }
        private static void DSSVCNTT(List<Student> listSV)
        {
            try
            {
                Student sv = new Student();
                List<Student> listSvCNTT = listSV.Where(p => p.Khoa == "CNTT").ToList();
                if (listSvCNTT.Count() == 0)
                {
                    throw new Exception("Không có sinh viên khoa CNTT");
                }
                XuatDSStudent(listSvCNTT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void DSSV5CNTT(List<Student> listSV)
        {
            try
            {
                List<Student> listSV5CNTT = listSV.Where(p => (p.DiemTB < 5) && (p.Khoa == "CNTT")).ToList();
                if (listSV5CNTT.Count() == 0)
                {
                    throw new Exception("Không có sinh viên khoa CNTT");
                }
                XuatDSStudent(listSV5CNTT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        private static void DSGVQ9(List<Teacher> listGV)
        {
            try
            {
                List<Teacher> listGVQ9 = listGV.Where(p => p.DiaChi.Contains("Quan 9")).ToList();
                if (listGVQ9.Count() == 0)
                {
                    throw new Exception("Không có giáo viên quận 9");
                }
                XuatDSTeacher(listGVQ9);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        private static void GvCHN060286(List<Teacher> listGV)
        {
            try
            {
                Teacher gv = listGV.Where(p => p.MaGV == "CHN060286").First();
                if (gv == null)
                {
                    throw new Exception("Không có giáo viên có mã CHN060286");
                }
                gv.Xuat();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        private static void DSSVMaxCNTT(List<Student> listSV)
        {
            try
            {
                List<Student> listSVCNTT = listSV.Where(p => (p.Khoa == "CNTT")).ToList();
                if (listSVCNTT.Count() == 0)
                {
                    throw new Exception("Không có sinh viên khoa CNTT");
                }
                double maxDiemTB = (listSV.Where(sv => sv.Khoa == "CNTT")).Max(sv => sv.DiemTB);
                List<Student> listSVMaxCNTT = listSV.Where(sv => sv.Khoa == "CNTT" && sv.DiemTB == maxDiemTB).ToList();
                XuatDSStudent(listSVMaxCNTT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
