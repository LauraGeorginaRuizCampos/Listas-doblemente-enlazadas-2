using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    internal class Lista
    {
        private Nodo primero;
        private Nodo ultimo;
        private string nombre;

        public Lista(string nombre)
        {
            this.nombre = nombre;
            primero = ultimo = null;
        }

        public Lista()
        {
            nombre = "Lista";
            primero = ultimo = null;
        }

        public Lista(object dato, string nombre)
        {
            this.nombre = nombre;
            primero = ultimo = new Nodo(dato);
        }

        public bool estaVacia()
        {
            return primero == null;
        }

        public void InsertarUltimo(object elemento)
        {
            if (estaVacia())
            {
                primero = ultimo = new Nodo(elemento);
            }
            else
            {
                ultimo = ultimo.Siguiente = new Nodo(elemento,null,ultimo);
            }
        }

        public void InsertarPrimero(object elemento)
        {
            if (estaVacia())
            {
                primero = ultimo = new Nodo(elemento);
            }
            else
            {
                primero = new Nodo(elemento, primero, null);
            }
        }

        public object BorrarPrimero()
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = primero.Dato;

            if (primero == ultimo)
            {
                primero = ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
            }
            return ElementoBorrado;
        }

        public object BorrarUltimo()
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = ultimo.Dato;

            if (primero == ultimo)
            {
                primero = ultimo = null;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != ultimo)
                {
                    actual = actual.Siguiente;
                }

                ultimo = actual;
                actual.Siguiente = null;
            }
            return ElementoBorrado;

        }

        public void Imprimirbackwards()
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }

            Console.WriteLine("Lista " + nombre);

            Nodo actual = ultimo;

            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Anterior;
            }


            Console.WriteLine("\n");
        }

        public void Imprimirnormal()
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }

            Console.WriteLine("Lista " + nombre);

            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }


            Console.WriteLine("\n");
        }

    }
}