using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimples
{
    public class Store : IPainel
    {
        public List<Item> ItensAvenda { get; set; }
        private Player CurrentPlayer { get; set; }

        public Store(Player player)
        {
            Item[] defaultItens = { new Item("Espada simples", 1200, 5),
                new Item("Poção de cura", 500, 50),
                new Item("Espada Encantada", 4500, 1),
                new Item("nada", 0, 0)};

            CurrentPlayer = player;
            ItensAvenda = defaultItens.ToList();
        }



        public void Draw()
        {
            int option = -1;
            var aux = 1;
            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine("Itens a venda:");
                foreach (var obj in ItensAvenda)
                {
                    Console.WriteLine(aux + obj.ToString() + "  --  $"+obj.Price) ;
                    aux++;
                }

                var item = HandInput(out option);
                Console.WriteLine($"Você comprou {item.Name} por ${item.Price}");
                Console.ReadKey();
            }
        }

        public Item HandInput(out int option)
        {
            if (int.TryParse(Console.ReadLine(), out option) && option <= ItensAvenda.Count)
            {
                var item = ComprarItem(option);

                option = 0;

                return item;
            }

            else
                throw new Exception();
        }


        public Item ComprarItem(int id)
        {
            id = id - 1;
            if (SaldoOK(ItensAvenda[id].Price))
            {
                ItensAvenda[id].Qtde = ItensAvenda[id].Qtde > 0 ? --ItensAvenda[id].Qtde : 0;
                var playerItem = new Item(ItensAvenda[id].Name, ItensAvenda[id].Price, 1);
                CurrentPlayer.Inventario.AddFromStore(playerItem);

                return ItensAvenda[id];
            }
            else
                Console.WriteLine("Saldo indisponível");
            return ItensAvenda.Last();
        }

        public bool SaldoOK(int valor)
        {
            return CurrentPlayer.DebitarSaldo(valor);
        }

    }
}