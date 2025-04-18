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
            ejercicio10();
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
            // Usamos \" para incluir comillas dobles dentro de la cadena de texto
            Console.WriteLine("\"Osvaldo Guerra\"");
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

        static void ejercicio5()
        {
            double baseT, altura, area;

            // Ingresa la base
            Console.Write("Ingresa la base del triángulo: ");
            baseT = double.Parse(Console.ReadLine());

            // Ingresa la altura
            Console.Write("Ingresa la altura del triángulo: ");
            altura = double.Parse(Console.ReadLine());

            area = (baseT * altura) / 2;

            Console.WriteLine("El área del triángulo es: " + area);
        }

        static void ejercicio6()
        {
            double num1, num2, num3, promedio;

            // Ingresar los tres números decimales
            Console.Write("Ingresa el primer número decimal: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número decimal: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer número decimal: ");
            num3 = double.Parse(Console.ReadLine());

            promedio = (num1 + num2 + num3) / 3;

            //Console.WriteLine("El promedio es: " + promedio.ToString("F2"));
            Console.WriteLine("El promedio es: " + Math.Round(promedio,2));
        }

        static void ejercicio7()
        {
            double radio, area;

            // Ingresar el radio 
            Console.Write("Ingresa el radio del círculo: ");
            radio = double.Parse(Console.ReadLine());

            // Calcular el área usando la fórmula área = π * radio^2
            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo es: " + Math.Round(area, 2));
        }

        static void ejercicio8()
        {
            double numero, raiz, poten;

            // Ingresar el número decimal
            Console.Write("Ingresa un número decimal: ");
            numero = double.Parse(Console.ReadLine());

            // Calcular la raíz cuadrada y la potencia cúbica
            raiz = Math.Sqrt(numero);
            poten = Math.Pow(numero, 3);

            Console.WriteLine("La raíz cuadrada es: " + Math.Round(raiz, 2));
            Console.WriteLine("La potencia a 3 es: " + Math.Round(poten, 2));
        }

        static void ejercicio9()
        {
            int a = 10, b = 20;

            Console.WriteLine("a = " +a+ ", b = " +b);
            Console.WriteLine();

            Console.WriteLine("Dado los siguientes valores se evalúa y muestra que :");
            Console.WriteLine();

            // Son iguales?
            Console.WriteLine("a y b son iguales?");
            Console.WriteLine("¿a == b? " + (a == b));
            Console.WriteLine();

            // Son diferentes?
            Console.WriteLine("a y b son diferentes?");
            Console.WriteLine("¿a != b? " + (a != b));
            Console.WriteLine();

            // a es mayor que b?
            Console.WriteLine("a es mayor que b?");
            Console.WriteLine("¿a > b? " + (a > b));
            Console.WriteLine();

            // a es menor que b?
            Console.WriteLine("a es menor que b?");
            Console.WriteLine("¿a < b? " + (a < b));
            Console.WriteLine();

            // a es mayor o igual que b?
            Console.WriteLine("a es mayor o igual que b?");
            Console.WriteLine("¿a >= b? " + (a >= b));
            Console.WriteLine();

            // a es menor o igual que b?
            Console.WriteLine("a es menor o igual que b?");
            Console.WriteLine("¿a <= b? " + (a <= b));
            Console.WriteLine();
        }

        static void ejercicio10()
        {
            bool x = true;
            bool y = false;

            Console.WriteLine("x = " +x+ ", y = " +y);
            Console.WriteLine();

            Console.WriteLine("Dado los siguientes valores se evalúa y muestra que :");
            Console.WriteLine();

            // Solo es true si ambos son true
            Console.WriteLine("Solo es true si ambos son true");
            Console.WriteLine("x && y = " + (x && y));
            Console.WriteLine();

            // Es true si al menos uno es true
            Console.WriteLine("Es true si al menos uno es true");
            Console.WriteLine("x || y = " + (x || y));
            Console.WriteLine();

            // Invierte el valor de x
            Console.WriteLine("Invierte el valor de x");
            Console.WriteLine("!x = " + (!x));
            Console.WriteLine();

            // Invierte el valor de y
            Console.WriteLine("Invierte el valor de y");
            Console.WriteLine("!y = " + (!y));
            Console.WriteLine();
        }
    }
}
