namespace _02_Avisos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new();

            av1.MostarAviso();

            AvisosTrafico av2 = new("Jefatura de Tráfico", "Sanción de Tráfico", "01/01/23");
            Console.WriteLine( av2.GetFecha());
            av2.MostarAviso();
        }
    }
}