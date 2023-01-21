namespace App_07_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Juan = new("Juan");
            Humano Macy = new("Macy");
            Gorila Kong = new("Kong");

            Kong.Respirar();
            Console.WriteLine(Kong.getNombre());
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