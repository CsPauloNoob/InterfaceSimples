using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceSimples
{
    internal class Inventario:IPainel //Aqui é feito o "contrato entre a Interface e a classe inventario, deve haver esse mesmo contarto na classe Store"
    {                                 //Todos os metodos publicos na Interface IPainel devem ser implementados nesta classe.
        public List<Item> Items;      
        public int Gold;



        public Inventario()
        {
            Items = new List<Item>();

            Items.Add(new Item(Items.Count + 1, "Katana", 10));   //Apenas para teste, só pode haver itens no inventario se forem comprados pela loja
            Gold = 20;
        }

        //classe Draw e HandInput são obrigatórias nas classes Inventario e Store, pois elas vem da interface iPainel
        public void Draw()
        {
            Console.Clear();

            foreach (Item item in Items)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }


        public void HandInput(int option)
        {

        }
    }
}
