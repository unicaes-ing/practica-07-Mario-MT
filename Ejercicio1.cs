using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7CS
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int cant, menores = 0, mayores = 0;
            Console.WriteLine("¿Cuantas edades ingresará?");
            int.TryParse(Console.ReadLine(),out cant);
            int[] edades = new int [cant];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona N°{0}", i + 1);
                edades[i] = Convert.ToInt32(Console.ReadLine());

                if (edades[i] >= 18)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }
            }
            Console.Clear();
            Console.Write("Total menores de edad: " + (menores));
            Console.Write("Total mayores de edad: " + (mayores));
            Console.ReadKey();
        }
    }
}
