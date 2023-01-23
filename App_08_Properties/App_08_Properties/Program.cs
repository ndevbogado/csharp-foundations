namespace App_08_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado nahuel = new("Nahuel D. Bogado");

            Console.WriteLine("Ingrese Salario: ");
            nahuel.SALARIO = int.Parse(Console.ReadLine());

            Console.WriteLine($"El salario es {nahuel.SALARIO}$");
        }

        class Empleado
        {
            public Empleado(string nombre) 
            {
                this.nombre = nombre;
            }

            /*
            public void setSalario(double salario)
            {
                if (salario < 0)
                {
                    Console.WriteLine("El salario no puede ser negativo. Se le asignará 0 como salario.");
                }
                else
                    this.salario = salario;
            }

            public double getSalario() => this.salario;
            */

            private double evaluaSalario(double salario)
            {
                if (salario < 0)
                    return 0;
                else
                    return salario;
            }

            //CREACIÓN DE PROPERTY
            public double SALARIO
            {
                get => this.salario;
                set => this.salario = evaluaSalario(value);
            }
            private string nombre;
            private double salario;
        }
    }
}