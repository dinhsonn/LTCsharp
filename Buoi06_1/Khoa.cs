using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_1
{
    public class Khoa
    {
        public string Makhoa { get; set; }
        public string Tenkhoa { get; set; }
        public string Ghichu { get; set; }

        public Khoa()
        {
        }

        public Khoa(string makhoa, string tenkhoa, string ghichu)
        {
            this.Makhoa = makhoa;
            this.Tenkhoa = tenkhoa;
            this.Ghichu = ghichu;
        }
    }
}
