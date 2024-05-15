using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace arbol_de_busqueda_binaria
{
    internal class Program
    {
        public static ABB arbolito = new ABB();
        public class ABB
        {
            class Nodo
            {
                public Nodo izquierda;
                public Nodo derecha;
                public int dato;
            }
            Nodo raiz;
            public ABB()
            {
                raiz =null;
            }
            public void insertar(int info) 
            { 
                Nodo nuevo= new Nodo();
                nuevo.dato = info;
                nuevo.izquierda = null;
                nuevo.derecha = null;
                if(raiz == null)raiz = nuevo;
                else
                {
                    Nodo anterior = null, valor;
                    valor = raiz;
                    while(valor !=null) 
                    {
                        anterior= valor;
                        if (info < valor.dato)
                            valor = valor.izquierda;
                        else
                            valor=valor.derecha;
                    
                    }
                    if (info < anterior.dato)
                        anterior.izquierda = nuevo;
                    else anterior.derecha = nuevo;

                }
                
            }
            private void imprimirPre(Nodo valor)//R-I-D
            {
                if(valor != null)
                {
                    Console.Write(valor.dato+" ");
                    imprimirPre(valor.izquierda);
                    imprimirPre(valor.derecha);
                }
            }
            public void imprimirPre()//esto sirve para llamar a la raiz
            {
                imprimirPre(raiz);
                Console.WriteLine();

            }

            private void imprimirINORDEN(Nodo valor)//I-R-D
            {
                if (valor != null)
                {

                    imprimirINORDEN(valor.izquierda);
                    Console.Write(valor.dato + " ");
                    imprimirPre(valor.derecha);
                }
            }
            public void imprimirINORDEN()
            {
                imprimirINORDEN(raiz);
                Console.WriteLine();

            }
            private void imprimirPOSORDEN(Nodo valor)//I-D-R
            {
                if (valor != null)
                {

                    imprimirPOSORDEN(valor.izquierda);
                    imprimirPOSORDEN(valor.derecha);
                    Console.Write(valor.dato + " ");
                }
            }
            public void imprimirPOSORDEN()//
            {
                imprimirPOSORDEN(raiz);
                Console.WriteLine();

            }
        } 
        static void Main(string[] args)
        {
            int opcion = 0;
            do {
                Console.WriteLine("Arbol de edadades");
                Console.WriteLine("1. insertar edad");
                Console.WriteLine("2. lista Inorden");
                Console.WriteLine("3. lista Preorden");
                Console.WriteLine("4. lista Posorden");
                Console.WriteLine("5. Salir");
                Console.WriteLine("dijite # de opcion : ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Insertar(); break;
                    case 2: ListaInOrden(); break;
                    case 3: ListaPreOrden(); break;
                    case 4: ListaPosOrden(); break;
                    case 5: Console.WriteLine("saliste del SW"); break;
                }
            } while (opcion!=5  );                  
            Console.ReadKey();

        }
        static void Insertar()
        {
            Console.Write("dijite edad: ");
            int edad=int.Parse(Console.ReadLine());
            arbolito.insertar(edad);

        }
        static void ListaPreOrden()
        {
            arbolito.imprimirPre();
        }
        static void ListaInOrden()
        {
            arbolito.imprimirINORDEN();
        }
        static void ListaPosOrden()
        {
            arbolito.imprimirPOSORDEN();
        }
    }
}
