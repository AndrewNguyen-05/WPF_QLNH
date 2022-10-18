using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Models
{
    internal class TaiKhoanModels
    {
        string username;
        string displayname;
        string password;
        int type; // 1: Admin, 0: User
        public string Username { get { return username; } set { username = value; } }
        public string Displayname { get { return displayname; } set { displayname = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Type { get { return type; } set { type = value; } }
    }
}
