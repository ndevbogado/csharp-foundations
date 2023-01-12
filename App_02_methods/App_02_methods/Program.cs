namespace App_02_methods
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
            mensajeEnPantalla();

            Console.WriteLine("Mensaje desde el main.");

            sumaNumeros(2,5);
        }

        static void mensajeEnPantalla ()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla.");
        }

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los números es: {num1 + num2}");
        }
    }
}