using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();
        }

        static void ejer1()
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros ingresados: ");
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }

        static void ejer2()
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };

            Console.WriteLine("Arreglo original: ");
            foreach (int n in num)
                Console.Write(n + " ");

            Console.WriteLine("\nArreglo modificado: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                    num[i] = 0;
            }
            foreach (int n in num)
                Console.Write(n + " ");
        }

        static void ejer3()
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };

            Console.Write("num = [");
            foreach (int n in num) ;
            Console.Write(num + ", ");
            Console.Write("]");

            int minimo = num[0];
            int maximo = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minimo)
                    minimo = num[i];

            }
        }

        static void ejer4()
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Números pares ingresados:");

            foreach (int n in num)
            {
                if (n % 2 == 0)
                    Console.WriteLine(n);
            }
        }


        static void ejer5()
        {
            Console.Write("¿Cuántos números desea ingresar?: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            int suma = 0;
            Console.WriteLine();
            for (int i = 0; i < cant; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];
            }

            Console.WriteLine("\nNúmeros ingresados: ");
            foreach (int n in num)
                Console.Write(n + " ");


        }

    }
}
