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


        public Item(string name, int price, int qtde)
        {  
            this.Name = name;
            this.Price = price;
            this.Qtde = qtde;
        }

        public override string ToString()
        {
            return $" - Item: {Name} x Quantidade: {Qtde}";
        }
    }
}