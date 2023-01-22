namespace App_07_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Juan = new("Juan");
            IMamiferosTerrestres IJuan = Juan;
            ISaltar ISaltarJuan = Juan;
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

            foreach (Mamifero mamifero in almacen)
            {
                Console.Write(mamifero.getNombre()+" ");
                mamifero.Pensar(); // Polimorfismo: código se comporta de distintas formas según el contexto. 
            }



            // Con el principio de sustitución gano la capacidad de agrupar y almacenar distintos tipos de objetos en un mismo array, pero pierdo la capacidad de llamar a los métodos propios de cada clase.

            Ballena moby = new("Moby Dick");

            moby.Nadar();

            Console.WriteLine($"Número de patas del caballo: {IJuan.NumeroPatas()}");
            Console.WriteLine($"Número de patas con las que salta el caballo: {ISaltarJuan.NumeroPatas()}");

         }

        interface IMamiferosTerrestres // Por convención, las interfaces se deben escribir con una 'I' al inicio de su nombre.
        {
            int NumeroPatas();
        }

        interface IAnimalesDeCarrerra
        {
            string TipoDeporte(string deporte);
            bool EsOlimpico(string respuesta);

        }

        interface ISaltar
        {
            int NumeroPatas();
        }
        class Mamifero
        {
            public Mamifero(String nombre) => this.nombreSerVivo = nombre;
            public void Respirar()
            {
                Console.WriteLine("Respirando");
            }
            public virtual void Pensar() => Console.WriteLine("Pensamiento básico instintivo.");

            public void Cuidar()
            {
                Console.WriteLine("Cuido de mis crías");
            }

            public String getNombre() => nombreSerVivo;

            private String nombreSerVivo;
        }

        class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesDeCarrerra, ISaltar // En C#, las interfaces van después del nombre de la clase.
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo) 
            {
                
            }
            public void Galopar()
            {
                Console.WriteLine("Galopando");
            }
            int IMamiferosTerrestres.NumeroPatas() => 4;

            int ISaltar.NumeroPatas() => 2;

            public string TipoDeporte(string deporte) => deporte;

            public bool EsOlimpico(string respuesta)
            {
                if (respuesta == "Y" || respuesta == "yes")
                    return true;
                else
                    return false;
            }
        }

        class Humano : Mamifero
        {
            public Humano(String nombreHumano) : base(nombreHumano) { }
            public override void Pensar() => Console.WriteLine("Soy capaz de realizar pensamientos abstractos xdxdxd.");
            public void Destruir()
            {
                Console.WriteLine("Destrucción del mundo inminente xdxdx");
            }
        }

        class Ballena: Mamifero
        {
            public Ballena(String nombreBallena) :base(nombreBallena)
            {

            }

            public void Nadar() => Console.WriteLine("Soy capaz de nadar");
        }
        class Gorila: Mamifero, IMamiferosTerrestres
        {
            public Gorila(String nombreGorila) : base(nombreGorila) { }
            public void Trepar()
            {
                Console.WriteLine("Trepando");
            }

            public override void Pensar() => Console.WriteLine("Pensamiento instintivo avanzado.");

            public int NumeroPatas()
            {
                return 2;
            }
        }
    }
}