namespace App_16_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjetoDelegado ElDelegado = new(MensajeBienvenida.SaludoBienvenida); //Creación del objeto com oreferencia de Delegado para la llamada del método perteneceiente a la clase llamada
            ElDelegado(); //Intancia del delegado para llamar al método

            ElDelegado = new(MensajeDespedida.SaludoDespedida);
            ElDelegado();
        }

        delegate void ObjetoDelegado(); 

        class MensajeBienvenida
        {
            public static void SaludoBienvenida()
            {
                Console.WriteLine("Hello There!");
            }
        }

        class MensajeDespedida
        {
            public static void SaludoDespedida()
            {
                Console.WriteLine("NOS VIMOS TIRRI!");
            }
        }

    }
}