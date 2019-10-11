using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7CS
{
    class Ejercicio5
    {
        public static int[,] Num1;
        public static int[,] Num2;

        static int sumar(int[,] datos)
        {
            int suma = 0;
            for (int f = 0; f < datos.GetLength(0); f++)
            {
                for (int c = 0; c < datos.GetLength(1); c++)
                {
                    suma += datos[f, c];
                }
            }
            return suma;
        }
        static int sumar2(int[,] datos)
        {
            int suma = 0;
            for (int f = 0; f < datos.GetLength(0); f++)
            {
                for (int c = 0; c < datos.GetLength(1); c++)
                {
                    suma += datos[f, c];
                }
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int total = 0;
            Num1 = new int[3, 3];
            Console.Write("Ingrese datos de la matriz 1: ");
            for (int f = 0; f < Num1.GetLength(0); f++)
            {
                for (int c = 0; c < Num1.GetLength(1); c++)
                {
                    string num;
                    num = Console.ReadLine();
                    Num1[f, c] = int.Parse(num);
                }
            }
            Num2 = new int[3, 3];
            Console.Write("Ingrese datos de la matriz 2: ");
            for (int f = 0; f < Num2.GetLength(0); f++)
            {
                for (int c = 0; c < Num2.GetLength(1); c++)
                {
                    string num;
                    num = Console.ReadLine();
                    Num2[f, c] = int.Parse(num);

                }
            }
            Console.Clear();
            total = sumar(Num1) + sumar(Num2);
            Console.WriteLine("La suma de la matrices es {0:N0}", total);
            Console.ReadKey();
        }
    }
}
