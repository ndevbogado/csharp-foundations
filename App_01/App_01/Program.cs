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
            
        }
    }
}