namespace App_06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int[] edades;

            edades = new int[4];

            edades[0] = 1;
            edades[1] = 5;
            edades[2] = 6;
            edades[3] = 7;

            Console.WriteLine(edades[2]);
            */

            //var arr = new[] { 15, 27, 2.2, 5 }; // Array implícito.

            Empleado empleado1 = new ("Obi-wan Kenobi", 35);
            Empleado empleado2 = new ("Monkey D. Luffy", 19);

            var empleados = new[] {empleado1, empleado2};

            /*
            Empleado[] empleados;
            empleados[0] = empleado1;
            empleados[1] = empleado2;
            */

            /*
            for (int i = 0; i < empleados.Length; i++) 
            {
                Console.WriteLine($"Name: {empleados[i].GetName()} / Age: {empleados[i].GetAge()}");
                //Console.WriteLine(edades[i]);
                //Console.WriteLine(arr[i]);
            }
            */

            /*
            foreach (var variableForeach in empleados)
                Console.WriteLine($"Name: {variableForeach.GetName()} - Age: {variableForeach.GetAge()}");
            */

            /*
            int[] numeros = new int[4];

            numeros[0] = 1;
            numeros[1] = 22;
            numeros[2] = 13;
            numeros[3] = 43;

            ProcesaDatos(numeros); // Los arrays pasados como parámetros se comportan como referencias de objetos. Si se modifican sus valores dentro de un método, se modifican para todo el programa (pointers)
            foreach( var datos in numeros)
                Console.WriteLine(datos);

            int numero = 0;
            Console.WriteLine("\n"+numero);
            ProcesaNumeros(numero); // el número pasado a este método no es una referencia al objeto original, por lo que no se modifica el valor de este ya que lo que se le pasa al método es una copia del valor de este.
            Console.WriteLine(numero);
            */

            int[] arrayElementos = LeerDatos();

            foreach(var arr in arrayElementos)
                Console.WriteLine(arr);
        }

        static void ProcesaDatos (int[] datos) 
        {
            for (int i =0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }

        static int[] LeerDatos ()
        {
            Console.Write("Cuántos elementos quieres que tenga el array? ");
            int respuesta = int.Parse(Console.ReadLine());

            int[] datos = new int[respuesta];

            for (int i = 0; i < datos.Length; i ++)
            {
                Console.Write($"Introduce el dato de la posición {i}: ");
                respuesta = int.Parse(Console.ReadLine());
                datos[i] = respuesta;
            }

            return datos;
        }

        static void ProcesaNumeros (int numero)
        {
            numero += 10;
        }

        class Empleado 
        {
            public Empleado (String nombre, int edad) 
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            private String nombre;
            private int edad;

            public String GetName() => this.nombre;
            public int GetAge() => this.edad;
        }
    }
}