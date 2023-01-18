using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_05_POO
{
    internal class Punto
    {
        public Punto() 
        {
            this.x = 0;
            this.y = 0;

            contadorDeObjetos++;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;

            contadorDeObjetos++;
        }

        private int x, y;
        private static int contadorDeObjetos = 0; // La directiva 'static' sirve cuando se desea utilizar una funcionalidad de la clase en sí, en vez de un objeto instanciado de esa clase

        public double DistanciaPunto(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double sqrSum = Math.Pow(xDif, 2) + Math.Pow(yDif, 2);
            double length = Math.Sqrt(sqrSum);

            return length;
        }

        public static int ContadorDeObjetos() => contadorDeObjetos;
        

    }
}
