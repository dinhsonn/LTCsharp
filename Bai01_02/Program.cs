using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap thang : ");
            int th = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap nam : ");
            int nm = Convert.ToInt16(Console.ReadLine());

            int songay = 0;

            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;

                    case 2:
                        if (checkNamNhuan(nm) == true)    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }
                Console.Write("=> Thang " + th + "/" + nm + " co " + songay + " ngay\n");
            }
            else
                Console.Write("=> Thang khong hop le!\n");
            Console.ReadKey();
        }
        public static bool checkNamNhuan(int nm)
        {
            if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))
                return true;
            else
                return false;
        }

    }
}
