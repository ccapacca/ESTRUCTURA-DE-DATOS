using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicando_en_colas
{
    internal class colita
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();

        public colita()
        {
            primero =null;
            ultimo = null;
        }
        public void encolar(string valor)


        {
            if (buscar(valor))
            {
                MessageBox.Show("El elemento ya existe en la cola.");
                return;
            }
            Nodo encolar=new Nodo();
            encolar.Dato = valor;
            if(primero == null)
            {
                primero = encolar;
                primero.Siguiente = null;
                ultimo=encolar;
            }
            else
            {
                ultimo.Siguiente= encolar;
                encolar.Siguiente= null;
                ultimo = encolar;
            }
        }   
        public void mostrar(ListBox lista)
        {
            lista.Items.Clear();
            Nodo cola = primero;
            
            while(cola != null )
            {
                lista.Items.Add( cola.Dato);
                cola=cola.Siguiente;
            }
            
        }

        public bool buscar(string valor)
       {       
            Nodo culito = primero;
            while (culito != null)
            {
                if (culito.Dato == valor)
                {
                    return true;
                }
                culito = culito.Siguiente;
            }
            return false;

        }

        public void desencolar()
        {
            if (primero != null)
            {
                primero = primero.Siguiente;
            }
            else
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
        }

        public void modificar(string valor1, string valor2)
        {           
                Nodo cul = primero;

                while (cul != null)
                {
                    if (cul.Dato == valor1)
                    {
                        cul.Dato = valor2;
                        MessageBox.Show("Dato modificado.");
                        return;
                    }
                    cul = cul.Siguiente;
                }

                MessageBox.Show("El dato a modificar no existe en la cola.");


        }
        public void elementos()
        {

            int cantidad = 0;
            Nodo actual = primero;

            while (actual != null)
            {
                cantidad++;
                actual = actual.Siguiente;
            }

            MessageBox.Show("La cola tiene " + cantidad + " elementos.");
        }
        public void destruir()
        {
            
            if (primero == null)
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


