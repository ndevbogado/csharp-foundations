using System.Text.Json.Nodes;

namespace App_09_Enums
{
    enum Estaciones {Primavera, Verano, Otonio, Invierno };
    enum Bonus {bajo=500, normal=1000, bueno=1500, extra=2000};
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Estaciones alergia = Estaciones.Primavera;
            Console.WriteLine(alergia);
            //Estaciones? alergia = null; // Esta sintaxis se utiliza cuando se necesita que una constante del tipo enum se le asigne el valor 'null'
            Console.WriteLine();

            Bonus Antonio = Bonus.bueno;

            Console.WriteLine(Antonio);

            double bonusAntonio = (double) Antonio;

            double salarioAntonio = 1500 + bonusAntonio;

            Console.WriteLine(salarioAntonio);
            */

            Empleado Nahuel = new(Bonus.extra, 1900.50);
            Console.WriteLine($"El salario del empleado es: {Nahuel.GetSalario()}");
        }

        class Empleado
        {
            private double salario, bonus;
            public Empleado(Bonus bonusEmpleado, double salario)
            {
                bonus = (double)bonusEmpleado;
                this.salario = salario;
            }

            public double GetSalario() => this.salario + this.bonus;
        }
    }
}