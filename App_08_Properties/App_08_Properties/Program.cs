namespace App_08_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Empleado nahuel = new("Nahuel D. Bogado");

            Console.WriteLine("Ingrese Salario: ");
            nahuel.SALARIO = int.Parse(Console.ReadLine());

            Console.WriteLine($"El salario es {nahuel.SALARIO}$");
            */
            Empleado empleado1 = new(1200,250);
            empleado1.camibiaSalario(empleado1, 100);
            Console.WriteLine(empleado1);
        }

        public struct Empleado
        {
            public double salarioBase, comision;
            public Empleado(int salarioBase, int comision)
            {
                this.salarioBase = salarioBase;
                this.comision = comision;
            }

            public override string ToString()
            {
                return string.Format("Salario y comisión del empleado ({0}, {1})", this.salarioBase, this.comision);
            }

            public void camibiaSalario(Empleado emp, double incremento)
            {
                emp.salarioBase += incremento;
                emp.comision+= incremento;
            }
        }

        /*
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

            public double getSalario() => this.salario;
            

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
    */
    }
}