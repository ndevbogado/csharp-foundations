namespace App_03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseas entrar al bucle 'while'?: ");
            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estás ejecutando el bucle 'while'.");
                Console.Write("Introduce tu nombre: ");

                string nombre = Console.ReadLine();

                Console.WriteLine($"{nombre}, saldrás cuando contestes 'no' a la pregunta.");

                respuesta = Console.ReadLine();

            }
            Console.WriteLine("Saliste del bucle 'while'.");
        }
    }
}