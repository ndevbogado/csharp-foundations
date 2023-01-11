/*
using System --> directiva para que el programa utilice el paquete 'System', del cual provienen
                 objetos como Console, etc.
*/

namespace App_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there!");

            int edad; //Variable declarada
            edad = 19; //Variable inicializada 

            int nuevaEdad = 20; //Variable declarada e inicializada

            // Nota: en C# una variable NO puede ser utilizada hasta que se inicialize por primera vez

            /*
            Console.WriteLine(5 / 2);
            Console.WriteLine(5.0 / 2.0);
            Console.WriteLine(5 / 2.0);
            */

            Console.WriteLine("\nString Concatenada: Edad = " + edad);
            Console.WriteLine($"String Interpolado: Edad = {edad}");
            //NOTA: la interpolación de Strings se realiza utlizando la siguiente estructura:
            //      string interpolada --> $"{variable}"

            Console.WriteLine($"\nedad  = 19 -> {edad}");
            Console.WriteLine($"edad  = 19 -> {edad++} (aun cuando el dato interpolado es edad++, debido al flujo de ejecución es de izq. a der.)");
            Console.WriteLine($"edad != 19 -> {edad} (en la línea de arriba, después de imprimir la linea se ejecuta la edad++)");
            Console.WriteLine($"edad != 20 -> {++edad} (utilicé ++edad en vez de edad++, para que el código se ejecute al mismo tiempo que la línea)");
            //NOTA: el flujo de ejecución de C# se realiza de arriba hacia abajo y de izquierda a derecha

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;


            //NOTA: Múltiple declaración e inicialización de variables en una sola línea.

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 66; //inicialización de cuatro edades

            /*
            int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 66

                La línea de arriba declara las variables de la edad de personas 1, 2, 3 y además declara 
                e inicializa la edad de la persona 4 en 66.
            */

            //NOTA: variables del tipo 'var'.

            var valorAutoAsignado = 0;

            //valorAutoAsignado = 0.5; --> esta línea tiraría un error

            /*
            El compilador en tiempo de ejecución declarará el tipo de dato de la varaible (int en este caso).
            Aun así, se debe respetar ese tipo de dato por el resto de la ejecución del programa.
            */

            //NOTA: Casting o conversión explícita de datos

            double temperatura = 34.5;
            int temperaturaSarandi;

            temperaturaSarandi = (int)temperatura; // Si no 'casteo' el dato temperatura tendré un typeError
        }
    }
}