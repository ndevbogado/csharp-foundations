﻿namespace App_02_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            ESQUEMA DE UN METODO EN C#:
            
            NOTA: en C# es indistinto el término de método o función
            NOTA: returnType void no regresa ningún valor
            
             returnType methodName (argType argName...)
            {
                {
                    main block;
                }
                
                return value;
            }
             */

            /*
             NOTA: Se puede simplificar el código si el método solo tiene una única línea de ejecución:

            returnType methodName (argType argName...) => ...; (no es necesario '{}' ni 'return').

            */

            //mensajeEnPantalla();

            //Console.WriteLine("Mensaje desde el main.");

            Console.Write("Escribe el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Escribe el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());


            Console.WriteLine(sumaNumeros((int)num1, (int)num2));
            Console.WriteLine(divideNumero(num1, num2));
        }

        static void mensajeEnPantalla ()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla.");
        }

        static int sumaNumeros(int num1, int num2)
        {
            //Console.WriteLine($"La suma de los números es: {num1 + num2}");
            return num1+num2;
        }

        static double divideNumero(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}