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
            ConversorEuroDolar MonedaActualizada = new(5.3);

            Moneda.cambiaValorEuro(3);
            Console.WriteLine($"Cambio: {Moneda.Convierte(50)}$ a {Moneda.GetEuro()} euros.");
            Console.WriteLine($"Cambio: {MonedaActualizada.Convierte(50)}$ a {MonedaActualizada.GetEuro()} euros.");
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
        public ConversorEuroDolar() // Constructor de la clase ConversorEuroDolar: da el valor inicial del campo de la clase. Estge se llama con el método new al instanciar la clase.
        {
            euro = 1.233;
        }
        public ConversorEuroDolar(double euro) // Sobrecarga de constructores.
        {
            this.euro = euro;
        }

        private double euro;

        public double Convierte (double cantidad)
        {
            return cantidad * euro;
        }

        public double GetEuro() //Método Getter que devuelve información para su lectura (Por convención se agrega el sufijo Get...)
        {
            return euro;
        }
        
        public void cambiaValorEuro (double nuevoValor) // Método de acceso para modificar campos de clase de manera controlada.
        {
            if ( nuevoValor >= 0 )
                euro = nuevoValor;  
            
        }
    }
}