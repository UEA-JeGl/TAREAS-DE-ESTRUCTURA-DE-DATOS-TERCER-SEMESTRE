using System;
using System.Collections.Generic;

namespace VacunacionCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // CREACIÓN DE CIUDADANOS
            // ================================
            HashSet<string> ciudadanos = new HashSet<string>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }

            // ================================
            // VACUNADOS PFIZER
            // ================================
            HashSet<string> pfizer = new HashSet<string>();
            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add($"Ciudadano {i}");
            }

            // ================================
            // VACUNADOS ASTRAZENECA
            // ================================
            HashSet<string> astraZeneca = new HashSet<string>();
            for (int i = 50; i <= 124; i++)
            {
                astraZeneca.Add($"Ciudadano {i}");
            }

            // ================================
            // OPERACIONES DE CONJUNTOS
            // ================================

            // Unión: todos los vacunados
            HashSet<string> vacunados = new HashSet<string>(pfizer);
            vacunados.UnionWith(astraZeneca);

            // No vacunados
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // Ambas dosis
            HashSet<string> ambasDosis = new HashSet<string>(pfizer);
            ambasDosis.IntersectWith(astraZeneca);

            // Solo Pfizer
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astraZeneca);

            // Solo AstraZeneca
            HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
            soloAstraZeneca.ExceptWith(pfizer);

            // ================================
            // RESULTADOS
            // ================================
            Console.WriteLine("===== RESULTADOS =====\n");
            Console.WriteLine($"Total ciudadanos: {ciudadanos.Count}");
            Console.WriteLine($"Vacunados: {vacunados.Count}");
            Console.WriteLine($"No vacunados: {noVacunados.Count}");
            Console.WriteLine($"Ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");

            MostrarEjemplos("No vacunados", noVacunados);
            MostrarEjemplos("Ambas dosis", ambasDosis);
            MostrarEjemplos("Solo Pfizer", soloPfizer);
            MostrarEjemplos("Solo AstraZeneca", soloAstraZeneca);
        }

        // Método para mostrar ejemplos
        static void MostrarEjemplos(string titulo, HashSet<string> conjunto)
        {
            Console.WriteLine($"\n--- {titulo} ---");
            int contador = 0;

            foreach (var ciudadano in conjunto)
            {
                Console.WriteLine(ciudadano);
                contador++;
                if (contador == 5) break;
            }
        }
    }
}