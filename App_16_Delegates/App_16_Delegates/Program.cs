namespace App_16_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "xd";
            ObjetoDelegado ElDelegado = new(MensajeBienvenida.SaludoBienvenida); //Creación del objeto com oreferencia de Delegado para la llamada del método perteneceiente a la clase llamada
            ElDelegado(mensaje); //Intancia del delegado para llamar al método

            ElDelegado = new(MensajeDespedida.SaludoDespedida);
            ElDelegado(mensaje);
        }

        delegate void ObjetoDelegado(string msj); 

        class MensajeBienvenida
        {
            public static void SaludoBienvenida(string msj)
            {
                Console.WriteLine("Hello There!: {0}", msj);
            }
        }

        class MensajeDespedida
        {
            public static void SaludoDespedida(string msj)
            {
                Console.WriteLine("NOS VIMOS TIRRI!: {0}", msj);
            }
        }

    }
}