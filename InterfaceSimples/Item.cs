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
        public int Slot;
        public string Name;
        public int Price;
        private int Quantidade; //Necessario função para incrementar itens repetidos no inventario


        public Item(int slot, string name, int price)
        {
            this.Slot = slot;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{Slot} - {Name} x {Quantidade}";
        }
    }
}