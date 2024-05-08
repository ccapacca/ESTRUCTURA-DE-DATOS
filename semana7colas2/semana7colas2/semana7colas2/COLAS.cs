using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana7colas2
{
    internal class COLAS
    {
        private NODO primero=null;
        private NODO ultimo=null;

        public void encolar(string nombre)
        {
            NODO nuevo =new NODO();
            nuevo.Nombre = nombre;

            if(primero==null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente= nuevo;
                nuevo.Siguiente=null;
                ultimo= nuevo;
            }
        }
        public void mostrar(ListBox lista)
        {
            
            NODO actual = primero;
            while(actual!=null)
            {
                lista.Items.Add(actual.Nombre);
                actual=actual.Siguiente;
            }
        }

        public void desencolar()
        {
            NODO actual=primero;
            if(primero==null)
            {
                MessageBox.Show("no hay nada en la cola");

            }
            else
            {
                //primero=primero .sguiente;
                actual = actual.Siguiente;
                primero=actual;
            }
        }
        public void elementos()
        {
           
            NODO actual = primero;
            int cantidad = 0;
            if (primero == null)
            {
                MessageBox.Show("cola vacia");
            }
            else
            {
                while(actual != null)
                {
                    cantidad++;
                    actual = actual.Siguiente;
                }
                MessageBox.Show("# elmentos : " + cantidad);
            }
        }
        public void destruir()
        {
            //primero = null;
            //ultimo = null;


            if(primero==null)
            {
                MessageBox.Show("cola vacia");

            }
            else
            {
                primero = null;
                ultimo = null;
            }
        }
        
    }
}
