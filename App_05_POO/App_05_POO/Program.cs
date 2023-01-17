namespace App_05_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo myCircle = new Circulo(); // Creación o instancia del objeto de tipo Circulo (variable del tipo objeto).

            Console.WriteLine(myCircle.calculoArea(5));

            Circulo myCircle2 = new Circulo();

            Console.WriteLine(myCircle2.calculoArea(4));
        }
    }

    class Circulo
    {
        const double PI = 3.1415; // Propiedad o 'campo de clase' de Circulo.

        public double calculoArea(int radio) // Método de clase. Nos indica el comportamiento de la clase Circulo.
        {
            return PI * radio * radio;
        }
    }
}