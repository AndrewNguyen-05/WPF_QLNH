using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Models
{
    internal class BanModels
    {
        int id;
        string? name;
        string? status; //Trong , Co nguoi
        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public string? Status { get { return status; } set { status = value; } }
    }
}
