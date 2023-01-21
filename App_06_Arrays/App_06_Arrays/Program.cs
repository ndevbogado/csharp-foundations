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

            foreach (var variableForeach in empleados)
                Console.WriteLine($"Name: {variableForeach.GetName()} - Age: {variableForeach.GetAge()}");
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