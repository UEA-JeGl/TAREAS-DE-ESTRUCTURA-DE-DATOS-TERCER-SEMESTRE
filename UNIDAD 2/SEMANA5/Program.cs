using System;
using System.Collections.Generic;

namespace EjerciciosListas
{
    class Curso
    {
        private List<string> asignaturas;

        public Curso()
        {
            asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        public List<string> ObtenerAsignaturas()
        {
            return asignaturas;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();

            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("EJERCICIO 1");
            Curso curso = new Curso();
            foreach (var asignatura in curso.ObtenerAsignaturas())
            {
                Console.WriteLine(asignatura);
            }
            Console.WriteLine();
        }

        static void Ejercicio2()
        {
            Console.WriteLine("EJERCICIO 2");
            Curso curso = new Curso();
            foreach (var asignatura in curso.ObtenerAsignaturas())
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
            Console.WriteLine();
        }

        static void Ejercicio3()
        {
            Console.WriteLine("EJERCICIO 3");
            Curso curso = new Curso();
            Dictionary<string, double> notas = new Dictionary<string, double>();

            foreach (var asignatura in curso.ObtenerAsignaturas())
            {
                Console.Write($"Ingrese la nota de {asignatura}: ");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(asignatura, nota);
            }

            foreach (var item in notas)
            {
                Console.WriteLine($"En {item.Key} has sacado {item.Value}");
            }
            Console.WriteLine();
        }

        static void Ejercicio4()
        {
            Console.WriteLine("EJERCICIO 4");
            List<int> numeros = new List<int>();

            Console.WriteLine("Ingrese 6 números ganadores de la lotería:");
            for (int i = 0; i < 6; i++)
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            numeros.Sort();
            Console.WriteLine("Números ordenados:");
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio5()
        {
            Console.WriteLine("EJERCICIO 5");
            List<int> numeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            numeros.Reverse();
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}

