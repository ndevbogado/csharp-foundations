namespace App_05_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Circulo myCircle = new Circulo(); // Creación o instancia del objeto de tipo Circulo (variable del tipo objeto).

            Console.WriteLine(myCircle.CalculoArea(5));

            Circulo myCircle2 = new(); // Una forma más reciente de instanciar un objeto.

            Console.WriteLine(myCircle2.CalculoArea(4));
            */

            ConversorEuroDolar Moneda = new();

            Moneda.cambiaValorEuro(3);
            Console.WriteLine(Moneda.Convierte(50));
        }
    }

    class Circulo

    {
        private const double PI = 3.1415; // Propiedad o 'campo de clase' de Circulo. Los identificadores != public son en camelCase (a menos que sean constantes)

        public double CalculoArea(int radio) // Método de clase. Nos indica el comportamiento de la clase Circulo.
            // Los identificadores public deben ser declarados en PascalCase
        {
            return PI * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte (double cantidad)
        {
            return cantidad * euro;
        }
        
        public void cambiaValorEuro (double nuevoValor)
        {
            if ( nuevoValor >= 0 )
                euro = nuevoValor;  
            
        }
    }
}