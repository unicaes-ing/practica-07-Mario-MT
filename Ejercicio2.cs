using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7CS
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int numeros, par = 0, impar = 0;
        Console.WriteLine("¿Cuantos números ingresará?");
            numeros = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[numeros];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Ingrese un número: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
            }
            Console.Clear();
            Console.WriteLine("Total de impares: "+ impar);
            Console.WriteLine("Total de pares: " + par);
            Console.ReadLine();
        }

    }
}
