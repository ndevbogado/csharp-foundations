namespace App_10_Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new();

            miArchivo.mensaje();



        }

        class ManejoArchivos
        {
            StreamReader archivo = null;
            int contador = 0;
            string linea;

            public ManejoArchivos()
            {
                archivo = new StreamReader(@"C:/Users/Nahue/Desktop/xd.txt");
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador ++;    
                }
            }
            public void mensaje ()
            {
                Console.WriteLine($"Hay {contador} líneas.");
            }

            ~ManejoArchivos()
            {
                archivo.Close();
                Console.WriteLine("El proceso finalizó. Archivo cerrado exitosamente.");
            }
        }
    }
}