using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7CS
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] arreglo = new int[6, 6];
            for (int f = 0; f < 6; f++)
            {
                for (int c = 0; c < 6; c++)
                {

                    int num = rnd.Next(10, 100);
                    arreglo[f, c] = num;

                    for (int i = 0; i < arreglo.Length; i++)
                    {

                        if (num == arreglo.Length)
                        {
                            num = rnd.Next(10, 100);
                            arreglo[f, c] = num;
                        }

                    }

                }
            }

            for (int a = 0; a < 6; a++)
            {
                for (int b = 0; b < 6; b++)
                {
                    Console.Write(arreglo[a, b] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
