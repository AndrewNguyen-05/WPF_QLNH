using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Models
{
    internal class HoaDonModels
    {
        int id;
        int datecheckin;
        int datecheckout;
        int idtable;
        int status; //1: Da thanh toan, 0: Chua thanh toan
        public int Id { get { return id; } set { id = value; } }
        public int Datecheckin { get { return datecheckin; } set { datecheckin = value; } }
        public int Datecheckout { get { return datecheckout; } set { datecheckout = value; } }
        public int Idtable { get { return idtable; } set { idtable = value; } }
        public int Status { get { return status; } set { status = value; } }
    }
}
