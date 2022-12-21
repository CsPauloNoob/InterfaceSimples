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
        public Dictionary<int,Item> Itens;      



        public Inventario()
        {
            Itens = new Dictionary<int, Item>();
        }

        //classe Draw e HandInput são obrigatórias nas classes Inventario e Store, pois elas vem da interface iPainel
        public void Draw()
        {
            int option = -1;
            var aux = 1;
            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine("Itens no seu inventário:");
                foreach (var item in Itens)
                {
                    Console.WriteLine(item.Key.ToString() + item.Value.ToString());
                    aux++;
                }

                    Console.WriteLine("Você usou uma unidade de: " + HandInput(out option).ToString());
                    Console.ReadKey();
            }


        }

        //trata a opção do usuário
        public Item HandInput(out int option)
        {
            if (int.TryParse(Console.ReadLine(), out option))
            {
                return UsarItem(option);
            }


            else
                return null;
        }

        //Retira o item usado do inventario
        public Item UsarItem(int itemId)
        {
            Item _item = Itens[itemId];

            _item.Qtde = _item.Qtde - 1;

            return _item;
        }
    }
}