using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejer1(0,0);

            //ejer2
            //Console.Write("Ingrese número 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese número 2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nSuma2: " + ejer2(num1, num2));

            //ejer3();

            Console.WriteLine("Suma4: " + ejer4());

            Console.ReadKey();
        }
        static void ejer1(int num1, int num2)
        {
            Console.Write("Ingrese número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma: " + (num1 + num2));
        }

        static int ejer2(int num1, int num2)
        {
            return num1 + num2;
        }

        static void ejer3()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma3: " + (num1 + num2));
        }

        static int ejer4()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            return num1 + num2;
        }
    }
}
