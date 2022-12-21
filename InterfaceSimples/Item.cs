using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceSimples
{
    public class Item
    {
        public string Name;
        public int Price;
        public int Qtde; //Quantidade


        public Item(string name, int price)
        {  
            this.Name = name;
            this.Price = price;
            this.Qtde = Qtde + 1;
        }

        public override string ToString()
        {
            return $" - {Name} x {Qtde}";
        }
    }
}