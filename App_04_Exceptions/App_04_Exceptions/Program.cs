namespace App_04_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = null;

            try
            {
                string line;

                int contador = 0;

                string path = @"C:/Users/Nahue/Desktop/text.txt";

                file = new System.IO.StreamReader(path);

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    contador++;
                }
            } catch (Exception e)
            {
                Console.WriteLine($"Error en la lectura del archivo: {e.Message}");
            } finally
            {
                if (file != null)
                {
                    file.Close();
                    Console.WriteLine("File successfuly closed.");
                }
            }

        }
    }
}