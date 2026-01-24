using System;
using System.Collections.Generic;

namespace UsoDePilas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("   APLICACIÓN DE PILAS EN C#");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Verificar expresión balanceada");
                Console.WriteLine("2. Resolver Torres de Hanoi");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        VerificarExpresion();
                        break;

                    case 2:
                        EjecutarHanoi();
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            }
            while (opcion != 0);
        }

        // -------------------- EJERCICIO 1 --------------------
        // Verificación de paréntesis, llaves y corchetes balanceados
        static void VerificarExpresion()
        {
            Console.Write("Ingrese la expresión matemática: ");
            string expresion = Console.ReadLine();

            Stack<char> pila = new Stack<char>();
            bool balanceada = true;

            foreach (char caracter in expresion)
            {
                if (caracter == '(' || caracter == '{' || caracter == '[')
                {
                    pila.Push(caracter);
                }
                else if (caracter == ')' || caracter == '}' || caracter == ']')
                {
                    if (pila.Count == 0)
                    {
                        balanceada = false;
                        break;
                    }

                    char ultimo = pila.Pop();

                    if (!Coinciden(ultimo, caracter))
                    {
                        balanceada = false;
                        break;
                    }
                }
            }

            if (pila.Count != 0)
                balanceada = false;

            Console.WriteLine(balanceada
                ? "Resultado: Fórmula balanceada."
                : "Resultado: Fórmula no balanceada.");
        }

        static bool Coinciden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }

        // -------------------- EJERCICIO 2 --------------------
        // Resolución de las Torres de Hanoi usando pilas
        static void EjecutarHanoi()
        {
            Console.Write("Ingrese el número de discos: ");
            int discos = int.Parse(Console.ReadLine());

            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            for (int i = discos; i >= 1; i--)
            {
                origen.Push(i);
            }

            Console.WriteLine("\nMovimientos realizados:");
            ResolverHanoi(discos, origen, auxiliar, destino);
        }

        static void ResolverHanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino)
        {
            if (n == 1)
            {
                MoverDisco(origen, destino);
                return;
            }

            ResolverHanoi(n - 1, origen, destino, auxiliar);
            MoverDisco(origen, destino);
            ResolverHanoi(n - 1, auxiliar, origen, destino);
        }

        static void MoverDisco(Stack<int> origen, Stack<int> destino)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Se mueve el disco {disco}");
        }
    }
}
