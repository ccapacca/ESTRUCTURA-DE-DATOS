using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana7colas2
{
    internal class NODO
    {
        private string nombre;
        private NODO siguiente;

        public string Nombre { get => nombre; set => nombre = value; }
        internal NODO Siguiente { get => siguiente; set => siguiente = value; }
    }
}
