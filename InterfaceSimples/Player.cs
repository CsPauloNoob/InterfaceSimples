using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimples
{
    public class Player
    {
        public string Name { get; set; }

        public int Gold { get; set; }

        public Inventario Inventario { get; set; }


        public Player(string nome = "Player1") //valor default para testes
        {
            Name = nome;
            Gold = 15000;
            Inventario = new Inventario();
        }


        public bool DebitarSaldo(int debito)
        {
            if (Gold < debito)
                return false;

            else
                Gold = Gold - debito;
            return true;
        }
    }
}