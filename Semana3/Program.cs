using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio4();
            Console.ReadKey();
        }

        static void ejercicio1()
        {

            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n" + nombre +", Bienvenido al curso Fundamentos de Algoritmos");
        }

        static void ejercicio2()
        {

            Console.Write("Osvaldo \n25 \nIng. Sistemas");
        }

        static void ejercicio3()
        {

            // Tarea para la proxima semana
        }
         static void ejercicio4()
        {
            int num1, num2;

            Console.Write("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es:" + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.WriteLine("El modulo es: " + (num1 % num2));
            Console.WriteLine();
        }
    }
}
