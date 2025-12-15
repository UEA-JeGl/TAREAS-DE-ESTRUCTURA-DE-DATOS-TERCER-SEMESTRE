using System;

class Estudiante
{
    // Atributos del estudiante
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos;

    // Método para ingresar datos
    public void IngresarDatos()
    {
        Console.Write("Ingrese ID del estudiante: ");
        Id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombres: ");
        Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        Direccion = Console.ReadLine();

        // Inicialización del array de teléfonos
        Telefonos = new string[3];

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.Write($"Ingrese teléfono {i + 1}: ");
            Telefonos[i] = Console.ReadLine();
        }
    }

    // Método para mostrar datos
    public void MostrarDatos()
    {
        Console.WriteLine("\n----- DATOS DEL ESTUDIANTE -----");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos registrados:");

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación del objeto estudiante
        Estudiante estudiante = new Estudiante();

        // Ingreso y presentación de datos
        estudiante.IngresarDatos();
        Console.Clear();
        estudiante.MostrarDatos();

        Console.WriteLine("\nPresione una tecla para finalizar...");
        Console.ReadKey();
    }
}
