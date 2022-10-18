using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Models
{
    class FoodMenuModels
    {
        int id;
        string? name;
        double discount;
        double price;
        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public double Discount { get { return discount; } set { discount = value; } }
    }
}
