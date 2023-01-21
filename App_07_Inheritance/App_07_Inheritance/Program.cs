namespace App_07_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Juan = new("Juan");
            Humano Macy = new("Macy");
            Gorila Kong = new("Kong");

            /*
            Kong.Respirar();
            Console.WriteLine(Kong.getNombre());
            */
            Mamifero animal = new Caballo("Juaan"); // Aplico principio de sustitución. 'Un caballo es siempre un mamífero?' Se puede almacenar un objeto caballo dentro de un objeto mamífero.

            //Caballo[] almacenCaballo = new Caballo[3];
            Mamifero[] almacen = new Mamifero[3]; 
            almacen[0] = Juan;
            almacen[1] = Macy;
            almacen[2] = Kong;

            // Con el principio de sustitución gano la capacidad de agrupar y almacenar distintos tipos de objetos en un mismo array, pero pierdo la capacidad de llamar a los métodos propios de cada clase.


         }

        class Mamifero
        {
            public Mamifero(String nombre) => this.nombreSerVivo = nombre;
            public void Respirar()
            {
                Console.WriteLine("Respirando");
            }

            public void Cuidar()
            {
                Console.WriteLine("Cuido de mis crías");
            }

            public String getNombre() => nombreSerVivo;

            private String nombreSerVivo;
        }

        class Caballo : Mamifero
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo) 
            {
                
            }
            public void Galopar()
            {
                Console.WriteLine("Galopando");
            }
        }

        class Humano : Mamifero
        {
            public Humano(String nombreHumano) : base(nombreHumano) { }
            public void Destruir()
            {
                Console.WriteLine("Destrucción del mundo inminente xdxdx");
            }
        }

        class Gorila: Mamifero
        {
            public Gorila(String nombreGorila) : base(nombreGorila) { }
            public void Trepar()
            {
                Console.WriteLine("Trepando");
            }
        }
    }
}