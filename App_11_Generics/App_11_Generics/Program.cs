namespace App_11_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            almacenObjetos <Empleado> archivo = new(5);

            /*
            archivo.agregar("Nahuel");
            archivo.agregar("Vader");
            archivo.agregar("Luffy");
            archivo.agregar("Kratos");
            archivo.agregar("Vin");
            */

            archivo.agregar(new Empleado(1500));
            archivo.agregar(new Empleado(1200));
            archivo.agregar(new Empleado(200));
            archivo.agregar(new Empleado(100));
            archivo.agregar(new Empleado(10));

            //string nombrePersona = (string)archivo.getElemento(4); // No salta en vs , pero da un error en tiempo de ejecución debido al casting
            Empleado persona = archivo.getElemento(4);
            Console.WriteLine(persona.getSalario());


         
        }

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
    }
}