﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio6();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            int num1;

            Console.Write("Ingrese un número entero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("\nEl número es par");

            }
            else
            {
                Console.WriteLine("\nEl número es impar");
            }

        }

        static void ejercicio2()
        {
            int edad;

            Console.Write("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad<0)
            {
                Console.WriteLine("\nEdad inválida!");
            }
            else if (edad<18)
            {
                Console.WriteLine("\nEs menor de edad");
            }
            else
            {
                Console.WriteLine("\nEs mayor de edad");
            }           
        }

        static void ejercicio3()
        {
            Console.Write("Ingrese sueldo base: ");
            double sueldo = double.Parse(Console.ReadLine());

            double maria = (sueldo * 0.95) - 25;
            double juan = (sueldo * 1.23) + 72;
            double patricio = (sueldo * 1.05) - 56;

            Console.WriteLine();

            Console.WriteLine($"Sueldo de María: {maria:F2}");
            Console.WriteLine($"Sueldo de Juan: {juan:F2}");
            Console.WriteLine($"Sueldo de Patricio: {patricio:F2}");
            Console.WriteLine($"Suma de sueldos: {maria+juan+patricio:F2}");
        }

        static void ejercicio4()
        {
            Console.Write("Ingrese un año: ");
            int an = int.Parse(Console.ReadLine());
            if (an%4==0 & an%100!=0 | (an%400==0))
            {
                Console.WriteLine("Es año bisiesto");
            }
            else
                Console.WriteLine("No es año bisiesto");   
        }

        static void ejercicio5()
        {
            Console.Write("Ingrese un monto en S/: ");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione moneda: \n1. Dolares \n2. Euros");
            Console.WriteLine("Ingrse una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine($"USD: {(monto / 3.75):F2}");
                    break;
                case 2: Console.WriteLine($"EUR: {(monto / 4.05):F2}");
                    break;
                default: Console.WriteLine("Opción incorrecta");
                    break;
            }
        }

        static void ejercicio6()
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULO DE ÁREAS");
            Console.WriteLine("\n1. Cuadrado \n2. Rectángulo \n3. Triángulo \n4. Círculo");
            Console.Write("\nIngrese la opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1: Console.Write("Ingrese el lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.Write("El área del cuadrado es: " + (lado * lado));
                    break;
                case 2: Console.Write("Ingrese la base: ");
                    int baseR = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    int altR = int.Parse(Console.ReadLine());
                    Console.Write("El área del rectángulo es: " + (baseR * altR));
                    break;
                case 3:
                    Console.Write("Ingrese la base: ");
                    int baseT = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    int altT = int.Parse(Console.ReadLine());
                    Console.Write("El área del triángulo es: " + (baseT * altT) / 2);
                    break;
                case 4: Console.Write("Ingrese el radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.Write($"El área del círculo es: {(Math.PI * Math.Pow(radio,2)):F2}");
                    break;
                default : Console.Write("Opción no valida");
                    break;                 
            }
        }
    }
}
