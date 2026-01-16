using System;

namespace ListasEnlazadas
{
    // Clase Nodo
    class Nodo
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase Lista Enlazada
    class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para insertar al final
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // EJERCICIO 3: Método de búsqueda
        public int Buscar(int valor)
        {
            Nodo actual = cabeza;
            int contador = 0;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    contador++;
                }
                actual = actual.Siguiente;
            }

            if (contador == 0)
            {
                Console.WriteLine("El dato no fue encontrado en la lista.");
            }

            return contador;
        }

        // EJERCICIO 4: Eliminar nodos fuera de un rango
        public void EliminarFueraDeRango(int minimo, int maximo)
        {
            // Eliminar nodos al inicio
            while (cabeza != null && (cabeza.Dato < minimo || cabeza.Dato > maximo))
            {
                cabeza = cabeza.Siguiente;
            }

            Nodo actual = cabeza;

            while (actual != null && actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato < minimo || actual.Siguiente.Dato > maximo)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                }
                else
                {
                    actual = actual.Siguiente;
                }
            }
        }

        // Mostrar lista
        public void Mostrar()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            Random rnd = new Random();

            // EJERCICIO 4: Crear lista con 50 números aleatorios
            for (int i = 0; i < 50; i++)
            {
                lista.Insertar(rnd.Next(1, 1000));
            }

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Rango leído desde teclado
            Console.Write("Ingrese valor mínimo del rango: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor máximo del rango: ");
            int max = int.Parse(Console.ReadLine());

            lista.EliminarFueraDeRango(min, max);

            Console.WriteLine("Lista después de eliminar valores fuera del rango:");
            lista.Mostrar();

            // EJERCICIO 3: Búsqueda
            Console.Write("Ingrese el valor a buscar: ");
            int valorBuscar = int.Parse(Console.ReadLine());

            int repeticiones = lista.Buscar(valorBuscar);
            if (repeticiones > 0)
            {
                Console.WriteLine($"El valor se encuentra {repeticiones} veces en la lista.");
            }
        }
    }
}
