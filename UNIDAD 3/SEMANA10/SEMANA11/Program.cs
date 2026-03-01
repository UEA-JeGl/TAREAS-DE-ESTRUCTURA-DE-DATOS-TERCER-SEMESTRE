using System;
using System.Collections.Generic;
using System.Text;

class Traductor
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto"},
        {"government", "gobierno"},
        {"company", "empresa"}
    };

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int opcion;

        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Debe ingresar un número válido.");
                opcion = -1;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;

                case 2:
                    AgregarPalabra();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();

        string[] palabras = frase.Split(' ');
        string resultado = "";

        foreach (string palabra in palabras)
        {
            string palabraLimpia = palabra.Replace(".", "")
                                          .Replace(",", "")
                                          .Replace(";", "")
                                          .Replace(":", "");

            if (diccionario.ContainsKey(palabraLimpia))
            {
                resultado += diccionario[palabraLimpia] + " ";
            }
            else
            {
                resultado += palabra + " ";
            }
        }

        Console.WriteLine("\nTraducción: " + resultado);
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese la traducción en español: ");
        string espanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}