using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimples
{
    internal interface IPainel
    {
        public void Draw();

        public Item HandInput(out int option);
    }
}