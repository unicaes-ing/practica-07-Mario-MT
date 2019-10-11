using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7CS
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int equipos, integrantes;
            Console.WriteLine("¿cuantos equipos son?");
            equipos = Convert.ToInt32(Console.ReadLine());
            string[][] grupo;
            grupo = new string[equipos][];
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.WriteLine("¿Cuantos integrantes tiene el equipo {0}?", (i + 1));
                integrantes = Convert.ToInt32(Console.ReadLine());
                grupo[i] = new string[integrantes];
                for (int j = 0; j < grupo[i].Length; j++)
                {
                    Console.WriteLine("Escriba el nombre del integrante N°{0} del equipo {1}", (j + 1), (i + 1));
                    grupo[i][j] = Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Equipos de futbol:");
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.WriteLine("Equipo N {0}:", (i + 1));
                for (int j = 0; j < grupo[i].Length; j++)
                {
                    Console.WriteLine(grupo[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
