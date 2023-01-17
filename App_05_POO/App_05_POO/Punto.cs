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
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private int x, y;

        public double DistanciaPunto(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double sqrSum = Math.Pow(xDif, 2) + Math.Pow(yDif, 2);
            double length = Math.Sqrt(sqrSum);

            return length;
        }

    }
}
