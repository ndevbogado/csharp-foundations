namespace App_06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades;

            edades = new int[4];

            edades[0] = 1;
            edades[1] = 5;
            edades[2] = 6;
            edades[3] = 7;

            Console.WriteLine(edades[2]);
        }
    }
}