namespace App_08_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado nahuel = new("Nahuel D. Bogado");
        }

        class Empleado
        {
            public Empleado(string nombre) 
            {
                this.nombre = nombre;
            }

            public void setSalario(double salario)
            {
                if (salario < 0)
                {
                    Console.WriteLine("El salario no puede ser negativo. Se le asignará 0 como salario.");
                }
                else
                    this.salario = salario;
            }

            private string nombre;
            private double salario;
        }
    }
}