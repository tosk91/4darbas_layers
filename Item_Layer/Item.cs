using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Layer
{
    public class Item
    {
        int id;
        string name;
        int amount;
        double price;
        string type;
        int rgb;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Rgb
        {
            get { return rgb; }
            set { rgb = value; }
        }
    }
}
