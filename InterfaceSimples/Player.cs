using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimples
{
    internal class Player
    {
        public string Name { get; set; }

        public int Money { get; set; }

        public Inventario Inventario { get; set; }


        public Player(string nome = "Player1") //valor default para testes
        {
            Name = nome;
            Money = 1500;
            Inventario = new Inventario();
        }
    }
}