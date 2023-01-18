/*
using static System.Math;
using static System.Console; // Directiva de importación que evita utilizar en nombre de la clase escrita (práctica no recomendada para programas largos)
*/

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

            /*
            ConversorEuroDolar Moneda = new();
            ConversorEuroDolar MonedaActualizada = new(5.3);

            Moneda.SetValorEuro(3);
            Console.WriteLine($"Cambio: {Moneda.Convierte(50)}$ a {Moneda.GetEuro()} euros.");
            Console.WriteLine($"Cambio: {MonedaActualizada.Convierte(50)}$ a {MonedaActualizada.GetEuro()} euros.");
            */

            //realizarTarea();

            //WriteLine(Pow(3,4));

            var miVariable = new { Name="Nahuel D. Bogado", Age=24 }; //Clase anónima
            Console.WriteLine(miVariable.Name);
            var otraVariable = new { Name = "XD", Age=0}; //Otra clase anónima que el compilador la identifica como la misma que la de arriba, ya que se fija en la cantidad de campos, del tipo y orden de construcción.

            /*
                NOTA: Las clases anónimas tienen cuatro condiciónes para ser utilizadas sin errores:
                    - Solo pueden contener campos públicos.
                    - Todos los campos tienen que ser iniciados.
                    - Los cmapos no pueden ser static.
                    - No se pueden definir métodos.
             */
        }

        static void realizarTarea()
        {
            Punto origen = new(5,5);
            Console.WriteLine($"Instancias de la Clase Punto: {Punto.ContadorDeObjetos()}");

            Punto destino = new(1,2);
            Console.WriteLine($"Instancias de la Clase Punto: {Punto.ContadorDeObjetos()}"); // Sentencia que llama a un método static de la clase Punto (funcionalidad independiente de la instancia de clase [objeto] que utiliza directamente TODA la clase) 

            double distancia = origen.DistanciaPunto(destino);

            Console.WriteLine($"La distancia entre los puntos es D = {distancia}");
            
        }
    }

    class Circuloqq

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
            this.euro = euro; // this.euro hace referencia al campo 'euro' de la clase, mientras que solo 'euro' hace referencia al parámetro del método.
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
        
        public void SetValorEuro (double nuevoValor) // Método Setter de acceso para modificar campos de clase de manera controlada.
        {
            if ( nuevoValor >= 0 )
                euro = nuevoValor;  
            
        }
    }
}