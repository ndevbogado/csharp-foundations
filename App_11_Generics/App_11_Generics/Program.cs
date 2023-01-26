namespace App_11_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // almacenObjetos <Empleado> archivo = new(5);

            /*
            archivo.agregar("Nahuel");
            archivo.agregar("Vader");
            archivo.agregar("Luffy");
            archivo.agregar("Kratos");
            archivo.agregar("Vin");
            */

            /*
            archivo.agregar(new Empleado(1500));
            archivo.agregar(new Empleado(1200));
            archivo.agregar(new Empleado(200));
            archivo.agregar(new Empleado(100));
            archivo.agregar(new Empleado(10));

            //string nombrePersona = (string)archivo.getElemento(4); // No salta en vs , pero da un error en tiempo de ejecución debido al casting
            Empleado persona = archivo.getElemento(4);
            Console.WriteLine(persona.getSalario());
            */

            AlmacenEmpleados<Director> empleados = new(3);
            empleados.agregar(new Director(2500));
            empleados.agregar(new Director(3500));
            empleados.agregar(new Director(4500));

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(empleados.GetEmpleado(i).GetSalario());
            }
        }

        interface IParaEmpleados
        {
            double GetSalario();
        }
        
        class AlmacenEmpleados <T> where T: IParaEmpleados // Clase genérica que maneja cualquier tipo de objetos PERO que tengan el método GetSalario de la interfaz. 
        {
            public AlmacenEmpleados (int z)
            {
                datosEmpleado = new T[z];
            }

            public void agregar( T obj)
            {
                datosEmpleado[i] = obj;
                i++;
            }
            public T GetEmpleado(int i) => datosEmpleado[i];
            private int i = 0;
            private T[] datosEmpleado;
        }

        class Director: IParaEmpleados
        {
            public Director(double salario) => this.salario = salario;

            public double GetSalario() => salario;

            private double salario;
            
        }

        class Secretaria: IParaEmpleados
        {
            public Secretaria(double salario) => this.salario = salario;

            public double GetSalario() => salario;

            private double salario;
        }

        class Electricista: IParaEmpleados
        {
            public Electricista(double salario) => this.salario = salario;
            public double GetSalario() => GetSalario();

            private double salario;
        }

        /*
        class almacenObjetos <T>
        {
            public almacenObjetos(int z)
            {
                datosElemento = new T[z];
            }

            public void agregar (T obj)
            {
                datosElemento[i] = obj;
                i++;
            }
            public T getElemento(int z) => datosElemento[z];

            private T[] datosElemento;
            private int i = 0;
        }

        class Empleado
        {
            private double salario;

            public Empleado(double salario)
            {
                this.salario = salario;
            }
            public double getSalario() => salario;
        }
        */
    }
        
}