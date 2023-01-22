using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Avisos
{
    internal class AvisosTrafico : IAvisos
    {
        public AvisosTrafico()
        {
            this.remitente = "DGT";
            this.mensaje = "Sanción cometida...";
            this.fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string GetFecha() => fecha;

        public void MostarAviso() => Console.WriteLine($"Mensaje {this.mensaje} ha sido enviado por {this.remitente} el día {this.fecha}");

        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
