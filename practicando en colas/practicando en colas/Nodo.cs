using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicando_en_colas
{
    internal class Nodo
    {
        private Nodo siguiente;
        private string dato;

        public string Dato { get => dato; set => dato = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
