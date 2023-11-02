using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an.Model
{
    class Temp
    {
        private static string _user;
        private static bool _isAdmin;
        public static string User { get => _user; set => _user = value; }
        public static bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
    }
}
