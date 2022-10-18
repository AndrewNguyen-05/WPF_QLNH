using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Models
{
    internal class CTHDModels
    {
        int id;
        int idbill;
        int idfood;
        int count;
        public int Id { get { return id; } set { id = value; } }
        public int Idbill { get { return idbill; } set { idbill = value; } }
        public int Idfood { get { return idfood; } set { idfood = value; } }
        public int Count { get { return count; } set { count = value; } }
    }
}
