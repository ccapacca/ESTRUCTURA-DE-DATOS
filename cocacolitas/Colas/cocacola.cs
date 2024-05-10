using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    internal class cocacola
    {
    Nodo primero =new Nodo();
        Nodo ultimo = new Nodo();

   public cocacola()
        {
            primero = null;
            ultimo = null;
        }

        public void encolar(int dato)
        {
            Nodo nuevo= new Nodo();
            nuevo.Dato = dato;
            if(dato >= 10 && dato <= 99)
            {
                if (primero == null)
                {
                    primero = nuevo;
                    primero.Siguiente = null;
                    ultimo = nuevo;
                }
                else if (buscar(dato) == true)
                {
                    MessageBox.Show("numero repetido");
                }
                else
                {
                    ultimo.Siguiente = nuevo;

                    nuevo.Siguiente = null;
                    ultimo = nuevo;
                }
            }
            else
            {
                MessageBox.Show(":v ingresa un buena dato ");
            }
            
        }
        public bool buscar(int valor)
        {
            Nodo actual= new Nodo();
            actual = primero;
            do
            {
                if(actual.Dato==valor)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }while( actual != null);
            return false;
        }

       
        public void desencolar()
        {
            
            primero=primero.Siguiente;

            //Nodo actual= new Nodo();
            //actual = primero;
            //while( actual != null )
            //{

            //}
        }
        public void listadododelacola(ListBox Lista)
        {
            Nodo actual=new Nodo();
            actual=primero.Siguiente;
            actual= primero;
            while ( actual != null)
            {
                Lista.Items.Add( actual.Dato );
                actual=actual.Siguiente;
            }
        }
        public void modificar(int valor1,int valor2)

        {

            Nodo actual = new Nodo();
            actual = primero;
            if (valor2 >= 10 && valor2 <= 99)

            {
                do 
            {
                if (actual.Dato == valor1)
                {
                    actual.Dato = valor2;
                }
                actual = actual.Siguiente;
            } while (actual != null);
            MessageBox.Show("dato modifcado");
            }
            
        
        }
        public void contar()
        {
            Nodo actual = new Nodo();
            actual = primero;
            int canp = 0, cani = 0;
            while ( actual != null )
            {
                if (actual.Dato % 2 == 0) canp++;
                else cani++;
                actual = actual.Siguiente;
            }
            MessageBox.Show("cantidad de pares es ;"+canp+"cantidad de impares es : "+cani+"total de elmentos es "+(cani+canp));           
        }
         
    }


}
