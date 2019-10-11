using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7CS
{
    class Ejercicio4
    {
        public static int[,] Num;
        public static void CargarDatos()
        {
            Num = new int[5, 5];
            Console.Write("Ingrese los numeros: ");
            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    string num;
                    num = Console.ReadLine();
                    Num[i, c] = int.Parse(num);
                }
            }
        }

        public static void Mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(Num[i,c] + "");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            CargarDatos();
            Mostrar();
            Console.ReadKey();
        }
    }
}
